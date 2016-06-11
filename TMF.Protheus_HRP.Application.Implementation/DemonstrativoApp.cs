using System;
using System.Linq;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo;
using TMF.Protheus_HRP.Domain.RequestResponse.Models;
using TMF.Protheus_HRP.Resources;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class DemonstrativoApp : IDemonstrativoApp
    {
        private readonly IDemonstrativoDal _dal;
        private readonly IFuncionarioDal _funcDal;
        private readonly ICargoDal _cargoDal;

        public DemonstrativoApp(IDemonstrativoDal iDal, IFuncionarioDal funcDal, ICargoDal cargoDal)
        {
            _dal = iDal;
            _funcDal = funcDal;
            _cargoDal = cargoDal;
        }

        public BuscarDemonstrativoResponse BuscarDemonstrativo(BuscarDemonstrativoRequest request)
        {
            var resp = new BuscarDemonstrativoResponse();
            if (request.TipoDemonstrativo == TipoDemonstrativo.AdiantamentoPLR)
                resp.BusinessErrors.Add(Messages.AdiantamentoPLRDesconsiderado);

            if (String.IsNullOrWhiteSpace(request.Periodo))
                resp.BusinessErrors.Add(Messages.PeriodoNaoInformado);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            if (request.TipoDemonstrativo == TipoDemonstrativo.DecimoTerceiro)
                request.Periodo = request.Periodo.Substring(0, 4) + "13";

            var funcionario = _funcDal.BuscarFuncionario(request.Matricula, request.CodigoFilial,request.CodigoEmpresa);
            if (funcionario == null)
            {
                resp.BusinessErrors.Add(Messages.FuncionarioNaoEncontrado);
                resp.IsValid = false;
                return resp;
            }

            string tipoDemonstrativoProtheus = null;
            switch (request.TipoDemonstrativo)
            {
                case TipoDemonstrativo.PagamentoMensal: tipoDemonstrativoProtheus = "3"; break;
                case TipoDemonstrativo.Adiantamento: tipoDemonstrativoProtheus = "1"; break;
                case TipoDemonstrativo.PLR: tipoDemonstrativoProtheus = "5"; break;
                case TipoDemonstrativo.PrimeiraParcelaDecimoTerceiro: tipoDemonstrativoProtheus = "10"; break;
                case TipoDemonstrativo.DecimoTerceiro: tipoDemonstrativoProtheus = "2"; break;
                default: break;
            }
            var demonstrativo = _dal.BuscarDemonstrativo(request.Matricula, request.CodigoFilial, request.CodigoEmpresa, tipoDemonstrativoProtheus, request.Periodo, request.Periodo);
            var cargo = _cargoDal.BuscarCargo(request.Matricula, request.CodigoFilial, request.CodigoEmpresa, demonstrativo.Cargo);
            demonstrativo.Cargo = demonstrativo.Cargo + " - " + cargo;
            return resp;
        }
    }
}
