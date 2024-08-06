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
    public class PresupuestosControllers : ControllerBase
    {
        private readonly PresupuestoRepositorio repositorio;
        private readonly IMapper mapper;

        //private readonly IMapper maper;

        public PresupuestosControllers(IPresupuestoRepositorio respositorio, IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Presupuesto>>> Get()
        {
            return await repositorio.Select();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Presupuesto>> Get(int id)
        {
            Presupuesto? zetta = await repositorio.SelectById(id);
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

        //**/*//***//////**/*
         public async Task<ActionResult> Put(int id, [FromBody] Presupuesto entidad)
         {
            if (id != entidad.Id)
            {
                return BadRequest("Datos Incorrectos");
            }
            var zetta = await repositorio.SelectById(id);

            if (zetta== null)
            {
                return NotFound("No existe el tipo de presupuesto buscado.");
            }

            zetta.Codigo = entidad.Codigo;
            zetta.Nombre = entidad.Nombre;
            zetta.Activo = entidad.Activo;

            try
            {
                await repositorio.Update(id, zetta);
                return Ok();
            }
            catch (Exception z)
            {
                return BadRequest(z.Message);
            }
         }

    }
}
