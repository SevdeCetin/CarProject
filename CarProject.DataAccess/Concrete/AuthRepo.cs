using CarProject.Core;
using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class AuthRepo : IAuthRepo
    {
        IhaleDBContext _context;
        public AuthRepo(IhaleDBContext Context)
        {
            _context = Context;
        }

        public async Task<Kullanici> Login(string username, string password)
        {
            var user = await _context.Kullanicis.FirstOrDefaultAsync(x => x.KullaniciAdi == username);
            if (user == null)
            {
                return null;
            }
            if (!KontrolEt(password, user.PasswordHash, user.PasswordSalt))
            {

            }
            return user;
        }
        private bool KontrolEt(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            if (passwordHash==null)
            {
                //byte[] passHash, passSalt;
                Olustur(password, out passwordHash, out passwordSalt);
            }
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var passHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < passHash.Length; i++)
                {
                    if (passHash[i] != passwordHash[i])
                    {
                        return false;
                    }

                }
                return true;
            }
        }

        public async Task<Kullanici> Register(Kullanici user, string password)
        {
            byte[] passHash, passSalt;
            Olustur(password, out passHash, out passSalt);
            user.PasswordHash = passHash;
            user.PasswordSalt = passSalt;
            await _context.Kullanicis.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        private void Olustur(string password, out byte[] passHash, out byte[] passSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                passSalt = hmac.Key;
            }
        }
        public async Task<bool> UserExist(string username)
        {
            if (!await _context.Kullanicis.AnyAsync(x => x.KullaniciAdi == username))
            {
                return false;
            }
            return true;
        }
    }
}
