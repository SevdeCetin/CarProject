using CarProject.API.Filters;
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
    public class AracController : ControllerBase
    {
        protected readonly IAracService _service;
        public AracController(IAracService Service)
        {
            _service = Service;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var degerler = await _service.CarList();
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
                var deger = await _service.GetAsync(id);
                if (deger != null)
                {
                    return Ok(deger);
                }
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpPost]
        public async Task<IActionResult> Post(AracDTO model)
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
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpPut]
        public async Task<IActionResult> Put(AracDTO model)
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

        [ServiceFilter(typeof(NotFoundFilter))]
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
