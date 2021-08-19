using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.services;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IServices;

namespace MN_Groop_A.P.S.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriServices _kategoriServices;
        public KategoriController(IKategoriServices kategoriServices)
        {
            _kategoriServices = kategoriServices;
        }
        //Https://localhost:5001/api/kategori
        [HttpGet]
         public async Task<IActionResult> GetAll()
        {
            try
            {
                //throw new Exception("Shoud fail");
                var kategori = await _kategoriServices.GetAllkategoris();
                return Ok(kategori);
            }
            catch (Exception ex )
            {

                return Problem(ex.Message);
            }
        }

        //Https://localhost:5001/api/kategori
        [HttpPost]
        public async Task<IActionResult> Create(Kategori kategori)
        {
            try
            {
                //throw new Exception("Shoud fail");
                if (kategori == null)
                {
                    return BadRequest("Kategori fail....");
                }
                var newKategori = await _kategoriServices.Create(kategori);
                return Ok(newKategori);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
            
        }

        //Https://localhost:5001/api/kategori
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Kategori kategori)
        {
            try
            {
                var updatekategori = await _kategoriServices.Update(id, kategori);
                if (updatekategori == null)
                {
                    return BadRequest("update failed");
                }
                return Ok(updatekategori);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
                
            }    
        }
        

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var deleteKatagori = await _kategoriServices.Delete(id);
                if (deleteKatagori == null)
                {
                    return BadRequest("delede failed ");
                }
                return Ok(deleteKatagori);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        
    }
}
