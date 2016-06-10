using System;
using System.Collections.Generic;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using TMF.Protheus_HRP.Application.Crosscutting;
using System.Linq;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class CabFunApp : ICabFuncApp
    {
        private readonly ICabFunDal _iCabFunDal;

        public CabFunApp(ICabFunDal iCabFunDal)
        {
            _iCabFunDal = iCabFunDal;
        }

        public ListarCabFuncionarioResponse ListarCabFuncionario(BuscarCabFuncionarioRequest request)
        {

            var resp = new ListarCabFuncionarioResponse();

            if (string.IsNullOrEmpty(request.Matricula))
                resp.BusinessErrors.Add("Matricula nao pode ser nula");

            if (string.IsNullOrEmpty(request.Filial))
                resp.BusinessErrors.Add("Filial nao pode ser nulo");

            if (string.IsNullOrEmpty(request.Usuario))
                resp.BusinessErrors.Add("Usuario nao pode ser nulo");

            if (string.IsNullOrEmpty(request.Senha))
                resp.BusinessErrors.Add("Senha nao pode ser nula");

            if (resp.BusinessErrors.Count != 0)
                return resp;

            var retornoMatricula = _iCabFunDal.BuscarMatriculaFilial(request.Matricula, request.Empresa, request.Filial);


            if (!retornoMatricula.Any())
                resp.BusinessErrors.Add("Usuário sem matricula cadastrada.");

            var retornoCabFuncionario = _iCabFunDal.BuscarCabFuncionario(request.Matricula, request.Empresa, request.Filial);

            if (!retornoCabFuncionario.Any())
                resp.BusinessErrors.Add("Usuário sem dados de cabecalho");

            return !resp.BusinessErrors.Any() ? retornoCabFuncionario.ProjectedAsSingle<ListarCabFuncionarioResponse>() : resp;


        }

    }
}
