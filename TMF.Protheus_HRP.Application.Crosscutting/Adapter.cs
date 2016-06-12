using AutoMapper;
using System.Collections.Generic;
using TMF.Protheus_HRP.Domain.RequestResponse.Models;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using Dto = TMF.Protheus_HRP.Domain.DTO;
using ReqResp = TMF.Protheus_HRP.Domain.RequestResponse;
using TMF.Protheus_HRP.Application.Crosscutting.Conversor;

namespace TMF.Protheus_HRP.Application.Crosscutting
{
    internal static class Adapter
    {
        static Adapter()
        {
            CreateMappers();
        }
        internal static T Adapt<T>(object item)
        {
            return Mapper.Map<T>(item);
        }
        private static void CreateMappers()
        {

            #region CabecalhoFuncionario

            Mapper.CreateMap<Dto.CabFuncionario, Funcionario>()
                .ReverseMap();
            Mapper.CreateMap<List<Dto.CabFuncionario>, ListarCabFuncionarioResponse>().ConvertUsing<ListarMatriculaConversor>();


            Mapper.CreateMap<Dto.AgenciaBanco, AgenciaBanco>().ReverseMap();
            Mapper.CreateMap<Dto.DadoGenerico, DadoGenerico>().ReverseMap();
            Mapper.CreateMap<Dto.Demonstrativo, Demonstrativo>().ReverseMap();
            #endregion

        }
    }
}
