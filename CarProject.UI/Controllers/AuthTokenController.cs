using CarProject.UI.ApiService;
using CarProject.UI.Models;
using CarProject.UI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.UI.Controllers
{
    public class AuthTokenController : Controller
    {
        private readonly TokenService _service;
        public static string _gelenToken;

        public AuthTokenController(TokenService tokenService)
        {
            _service = tokenService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDto)
        {
            var gelenToken = await _service.GetToken(loginDto);
            _gelenToken = gelenToken;
            MyToken.Token = gelenToken;
            if (gelenToken == null)
            {
                ViewBag.Msj = "Giriş yapılamadı";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
