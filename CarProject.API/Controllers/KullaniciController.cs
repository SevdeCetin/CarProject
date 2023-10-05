using CarProject.Business.Abstract;
using CarProject.Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        protected readonly IKullaniciService _service;
        public KullaniciController(IKullaniciService Service)
        {
            _service = Service;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var degerler = await _service.GetAllAsync();
                return Ok(degerler);
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }
             
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            try
            {
                var degerler = await _service.GetRolAsync(id);
                return Ok(degerler);
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post(KullaniciDTO model)
        {
            try
            {
                var deger = await _service.CreateAsync(model);
                return Ok(deger);
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }
        [HttpPut]
        public async Task<IActionResult> Put(KullaniciDTO model)
        {
            try
            {
                await _service.UpdateAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }
    }
}
