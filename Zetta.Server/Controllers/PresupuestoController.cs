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
        private readonly PresupuestoRepositorio respositorio;

        public PresupuestosController(IPresupuestoRepositorio respositorio)
        {
            this.respositorio = respositorio;
        }
    }
}
