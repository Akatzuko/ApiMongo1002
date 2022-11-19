using ApiProyecto1002.Models;
using ApiProyecto1002.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProyecto1002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        public EscuelaService _alumnoService;
        public AlumnosController(EscuelaService alumnoService)
        {
            _alumnoService = alumnoService;
        }
        [HttpGet]
        public ActionResult<List<Alumnos>> Get()
        {
            return _alumnoService.Get();
        }
        [HttpPost]

        public ActionResult<Alumnos> Create(Alumnos alumnos)
        {
            _alumnoService.Create(alumnos);
            return Ok(alumnos);
        }
        [HttpPut]
        public ActionResult Update (Alumnos alumnos)
        {
            _alumnoService.Update(alumnos.Id, alumnos);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _alumnoService.Delete(id);
            return Ok();
        }
    }
}
