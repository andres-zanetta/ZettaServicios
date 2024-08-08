using AutoMapper;
using Zetta.BD.Data.Entity;
using Zetta.Shared.DTO;

namespace Zetta.Server.Util
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CrearPresupuestoDTO, Presupuesto>();
          
        }
    }
}
