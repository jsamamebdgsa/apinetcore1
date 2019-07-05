using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entidades;
using Data.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        ICategoriaRepository categoriaRepository;

        public CategoriasController(ICategoriaRepository _categoriaRepository)
        {
            categoriaRepository = _categoriaRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return Ok(categoriaRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var categoria = categoriaRepository.GetDetail(id);
            if (categoria != null)
                return Ok(categoria);
            return NotFound();
        }
    }
}