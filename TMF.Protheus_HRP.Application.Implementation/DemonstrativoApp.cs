using System;
using System.Linq;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Application.Crosscutting;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo;
using Models = TMF.Protheus_HRP.Domain.RequestResponse.Models;
using TMF.Protheus_HRP.Resources;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class DemonstrativoApp : IDemonstrativoApp
    {
        private readonly IDemonstrativoDal _dal;
        private readonly IFuncionarioDal _funcDal;
        private readonly ICargoDal _cargoDal;
        private readonly ISalarioDal _salarioDal;

        public DemonstrativoApp(IDemonstrativoDal iDal, IFuncionarioDal funcDal, ICargoDal cargoDal, ISalarioDal salarioDal)
        {
            _dal = iDal;
            _funcDal = funcDal;
            _cargoDal = cargoDal;
            _salarioDal = salarioDal;
        }

        public BuscarDemonstrativoResponse BuscarDemonstrativo(BuscarDemonstrativoRequest request)
        {
            var resp = new BuscarDemonstrativoResponse();
            if (request.TipoDemonstrativo == Models.TipoDemonstrativo.AdiantamentoPLR)
                resp.BusinessErrors.Add(Messages.AdiantamentoPLRDesconsiderado);

            if (String.IsNullOrWhiteSpace(request.Periodo))
                resp.BusinessErrors.Add(Messages.PeriodoNaoInformado);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            if (request.TipoDemonstrativo == Models.TipoDemonstrativo.DecimoTerceiro)
                request.Periodo = request.Periodo.Substring(0, 4) + "13";

            var funcionario = _funcDal.BuscarFuncionario(request.Matricula, request.CodigoFilial, request.CodigoEmpresa);
            if (funcionario == null)
            {
                resp.BusinessErrors.Add(Messages.FuncionarioNaoEncontrado);
                resp.IsValid = false;
                return resp;
            }

            string tipoDemonstrativoProtheus = null;
            switch (request.TipoDemonstrativo)
            {
                case Models.TipoDemonstrativo.PagamentoMensal: tipoDemonstrativoProtheus = "3"; break;
                case Models.TipoDemonstrativo.Adiantamento: tipoDemonstrativoProtheus = "1"; break;
                case Models.TipoDemonstrativo.PLR: tipoDemonstrativoProtheus = "5"; break;
                case Models.TipoDemonstrativo.PrimeiraParcelaDecimoTerceiro: tipoDemonstrativoProtheus = "10"; break;
                case Models.TipoDemonstrativo.DecimoTerceiro: tipoDemonstrativoProtheus = "2"; break;
                default: break;
            }
            var demonstrativo = _dal.BuscarDemonstrativo(request.Matricula, request.CodigoFilial, request.CodigoEmpresa, tipoDemonstrativoProtheus, request.Periodo, request.Periodo);
            if(demonstrativo == null)
            {
                resp.BusinessErrors.Add(Messages.FuncionarioNaoEncontrado);
                resp.IsValid = false;
                return resp;
            }
            var cargo = _cargoDal.BuscarCargo(request.Matricula, request.CodigoFilial, request.CodigoEmpresa, demonstrativo.Cargo);
            demonstrativo.Cargo = demonstrativo.Cargo + " - " + cargo;
            var salario = _salarioDal.BuscarSalario(request.Matricula, request.CodigoFilial, request.CodigoEmpresa, request.CodigoEmpresa, request.Periodo);
            if (salario > 0)
                demonstrativo.Salario = salario;

            resp.Demonstrativo = demonstrativo.ProjectedAs<Models.Demonstrativo>();
            resp.IsValid = true;
            return resp;
        }
    }
}
