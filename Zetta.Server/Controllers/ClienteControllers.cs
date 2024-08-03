using Microsoft.AspNetCore.Mvc;
using Zetta.BD.Data.Entity;
using Zetta.Server.Repositorio;

namespace Zetta.Server.Controllers
{
    [ApiController]
    [Route("api/Presupuestos")]
    public class ClienteControllers:ControllerBase
    {
        private readonly PresupuestoRepositorio repositorio;

        public ClienteControllers(IPClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
