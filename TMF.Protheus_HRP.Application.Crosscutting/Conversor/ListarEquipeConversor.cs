using System.Collections.Generic;
using AutoMapper;
using TMF.FollowME.Domain.DTO;
using TMF.FollowME.Domain.RequestResponse.Equipe;

namespace TMF.FollowME.Application.Crosscutting.Conversor
{
    public class ListarEquipeConversor : ITypeConverter<List<Equipe>,BuscarEquipeResponse>
    {
        public BuscarEquipeResponse Convert(ResolutionContext context)
        {
            var model = new BuscarEquipeResponse();
            var source = (List<Equipe>)context.SourceValue;
            model.ListaEquipe = source.ProjectedAsCollection<Domain.RequestResponse.Models.Equipe>();
            return model;
        }
    }
}
