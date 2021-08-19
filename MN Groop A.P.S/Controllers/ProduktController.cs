using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IServices;


namespace MN_Groop_A.P.S.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktController : ControllerBase
    {
        private readonly IProduktServices _produktServices;
        public ProduktController(IProduktServices produktServices)
        {
            _produktServices = produktServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var produkt = await _produktServices.GetAllProduktors();
                if (produkt == null)
                {
                    return Problem("produkt reust failed");
                }
                if (produkt.Count == 0)
                {
                    return NoContent();
                }
                return Ok(produkt);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromRoute] int id)
        {
            try
            {
                var produkt = await _produktServices.GetProduktById(id);
                if (produkt == null)
                {
                    return NotFound();
                }
                return Ok(produkt);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Produkt produkt)
        {
            try
            {
                var newProdukt = await _produktServices.Create(produkt);
                if (newProdukt == null)
                {
                    return BadRequest("produkt create faill.....");
                }
                return Ok(newProdukt);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Produkt produkt)
        {
            try
            {
                var updateProdukt = await _produktServices.Update(id, produkt);
                if (updateProdukt == null)
                {
                    return BadRequest("Update for produkt failed..");
                }
                return Ok(updateProdukt);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
                throw;
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var deleteprodukt = await _produktServices.Delete(id);
                if (deleteprodukt == null)
                {
                    return BadRequest("produkt delete failed");
                }
                return Ok(deleteprodukt);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

    }
}
