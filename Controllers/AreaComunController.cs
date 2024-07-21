using ControlConjuntoServer.Server.Data;
using ControlConjuntoServer.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControlConjuntoServer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaComunController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AreaComunController(ApplicationDbContext context)
        {

            _context = context;
        }
        //Estado de conexion con el servidor
        [HttpGet]
        [Route("ConexionServidor")]
        public async Task<ActionResult<string>> GetConexionServidor()
        {
            return Ok("Conectado");
        }
        //Estados de conexion con la tabla de la base de datos
        [HttpGet]
        [Route("ConexionDB")]
        public async Task<ActionResult<string>> GetConexionDB()
        {
            try
            {
                var usuarios = await _context.AreaComuns.ToListAsync();
                return Ok("Buena Calidad");

            }
            catch (Exception ex)
            {
                return BadRequest("Mala calidad");
            }
        }
        //Aqui comienza el CRUD
        [HttpGet("Listado")]
        public async Task<ActionResult<List<AreaComun>>> GetAreaComuns()
        {
            var lista = await _context.AreaComuns.ToListAsync();
            return Ok(lista);
        }


        [HttpGet]
        [Route("ConsutarId/{id}")]
        public async Task<ActionResult<List<AreaComun>>> GetSingleAreaComun(int id)
        {
            var miobjeto = await _context.AreaComuns.FirstOrDefaultAsync(ob => ob.Id == id);
            if (miobjeto == null)
            {
                return NotFound(" :/");
            }

            return Ok(miobjeto);
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<string>> CreateAreaComun(AreaComun objeto)
        {
            try
            {
                _context.AreaComuns.Add(objeto);
                await _context.SaveChangesAsync();
                return Ok("Creado con éxio");
            }
            catch (Exception ex)
            {
                return BadRequest("Error durante el procesi de almacenamiento");
            }

        }

        [HttpPut("Actualizar/{id}")]
        public async Task<ActionResult<List<AreaComun>>> UpdateAreaComun(AreaComun objeto)
        {

            var DbObjeto = await _context.AreaComuns.FindAsync(objeto.Id);
            if (DbObjeto == null)
                return BadRequest("no se encuentra");
            //DbObjeto.Nombre = objeto.Nombre;
            await _context.SaveChangesAsync();
            return Ok(await _context.AreaComuns.ToListAsync());
        }


        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<ActionResult<string>> DeleteAreaComun(int id)
        {
            var DbObjeto = await _context.AreaComuns.FirstOrDefaultAsync(Ob => Ob.Id == id);
            if (DbObjeto == null)
            {
                return NotFound("no existe :/");
            }

            try
            {
                _context.AreaComuns.Remove(DbObjeto);
                await _context.SaveChangesAsync();

                return Ok("Eliminado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest("No fué posible eliminar el objeto");
            }

        }

    }
}