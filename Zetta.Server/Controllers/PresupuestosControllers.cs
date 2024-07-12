using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data;
using Zetta.BD.Data.Entity;
using Zetta.Server.Repositorio;

namespace Zetta.Server.Controllers
{
    [ApiController]
    [Route("api/Presupuesto")]
    public class PresupuestosController : ControllerBase
    {
        private readonly PresupuestoRepositorio repositorio;

        public PresupuestosController(ITPresupuestoRepositorio respositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Presupuesto>>> Get()
        {
            return await repositorio.Select();

        }

        [HttpPost]
        public async Task<ActionResult<List<Presupuesto>>> Post(Presupuesto entidad)
        {
            try
            {
                Context.Presupuesto.Add(entidad);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
