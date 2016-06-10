using System.Collections.Generic;
using AutoMapper;
using TMF.Protheus_HRP.Domain.DTO;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;

namespace TMF.Protheus_HRP.Application.Crosscutting.Conversor
{
    public class ListarMatriculaConversor : ITypeConverter<List<CabFuncionario>, ListarCabFuncionarioResponse>
    {
        public ListarCabFuncionarioResponse Convert(ResolutionContext context)
        {
            var model = new ListarCabFuncionarioResponse();
            var source = (List<CabFuncionario>)context.SourceValue;
            model.ListaFuncionario = source.ProjectedAsCollection<Domain.RequestResponse.Models.Funcionario>();
            return model;
        }
    }
}
