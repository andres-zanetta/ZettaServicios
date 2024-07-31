using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data;
using Zetta.BD.Data.Entity;
using Zetta.Server.Repositorio;
using Zetta.Shared.DTO;

namespace Zetta.Server.Controllers
{
    [ApiController]
    [Route("api/Presupuesto")]
    public class PresupuestosController : ControllerBase
    {
        private readonly PresupuestoRepositorio repositorio;
        private readonly IMapper mapper;

        //private readonly IMapper maper;

        public PresupuestosController(ITPresupuestoRepositorio respositorio, IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Presupuesto>>> Get()
        {
            return await repositorio.SelectByCod();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Presupuesto>> Get(int id)
        {
            var zetta = await repositorio.SelectById(id);
            if (zetta == null)
            {
                return NotFound();

            }
            return zetta;
        }

        [HttpGet("GetByCod/{cod}")]

        public async Task<ActionResult<Presupuesto>> GetbyCod(string cod)
        {
            Presupuesto? zetta = await repositorio.SelectByCod(cod);

            if (zetta == null)
            {
                return NotFound();
            }
            return zetta;
        }


        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await repositorio.Existe(id);
            return existe;
        }

        [HttpPost]

        public async Task<ActionResult<int>>Post(CrearPresupuestoDTO entidadDTO)
        {
            try
            {

             Presupuesto entidad = mapper.Map<Presupuesto>(entidadDTO);
             return await repositorio.Insert(entidad);
               
            }
            catch (Exception z)
            {

                return BadRequest(z.Message);
            }
        }
    }
}
