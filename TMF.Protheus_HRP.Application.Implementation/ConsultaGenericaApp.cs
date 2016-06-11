using System;
using System.Linq;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Application.Crosscutting;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;
using Models = TMF.Protheus_HRP.Domain.RequestResponse.Models;
using TMF.Protheus_HRP.Resources;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class ConsultaGenericaApp : IConsultaGenericaApp
    {
        private readonly IConsultaGenericaDal _iConsultaGenericaDal;

        public ConsultaGenericaApp(IConsultaGenericaDal iConsultaGenericaDal)
        {
            _iConsultaGenericaDal = iConsultaGenericaDal;
        }


        #region [Finalizados]
        public ConsultaGenericaReponse ListarCodigosAdicionalTempoServico(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.CodigosAdicionalTempoServico);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarAlteracoesSalariais(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.AlteracaoSalarial);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarEstadoCivil(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.EstadoCivil);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarGrauInstrucao(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.GrauInstrucao);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarTiposAfastamento(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.TipoAfastamento);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarNacionalidades(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.Nacionalidade);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarOrgaoRG(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.OrgaoRG);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarTiposVinculoRaiz(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.VinculoRaiz);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }
        
        public ConsultaGenericaReponse ListarRecebimento(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.Recebimento);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }
        
        public ConsultaGenericaReponse ListarSituacaoFuncionario(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.SituacaoFuncionario);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarTiposAdmissao(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.TipoAdmissao);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarTiposDemissao(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.TipoDemissao);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarTiposFuncionario(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.TipoFuncionario);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarUF(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.BuscarDadosSX5(request.Empresa, request.Filial, TiposSX5.UF);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ConsultaGenericaReponse ListarBancos(ConsultaDadoGenericoRequest request)
        {
            var resp = new ConsultaGenericaReponse();

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var dados = _iConsultaGenericaDal.ListarBancos(request.Empresa, request.Filial);

            resp.IsValid = true;
            resp.Dados = dados.ProjectedAsCollection<Models.DadoGenerico>();
            return resp;
        }

        public ListarAgenciasBancoResponse ListarAgenciasBanco(ListarAgenciasRequest request)
        {
            var resp = new ListarAgenciasBancoResponse();
            if (String.IsNullOrWhiteSpace(request.CodigoBanco))
                resp.BusinessErrors.Add(Messages.CodigoNulo);

            if (String.IsNullOrWhiteSpace(request.Empresa))
                resp.BusinessErrors.Add(Messages.EmpresaNula);

            if (String.IsNullOrWhiteSpace(request.Filial))
                resp.BusinessErrors.Add(Messages.FilialNula);

            if (resp.BusinessErrors.Any())
            {
                resp.IsValid = false;
                return resp;
            }
            var agencias = _iConsultaGenericaDal.ListarAgenciasBanco(request.CodigoBanco, request.Empresa, request.Filial);
            resp.IsValid = true;
            resp.Agencias = agencias.ProjectedAsCollection<Models.AgenciaBanco>();
            return resp;
        }
        #endregion


        public ConsultaGenericaReponse ListarHorarios(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDepartamentos(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCentroCustoDepartamento(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCentroCusto(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCargos(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarPaises(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarUnidadesFederativa(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCBO(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFuncoes(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCidades(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTurnos(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarNivelSalario(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarMotivosAfastramento(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarVerbas(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosFolha(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarSindicatos(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosLinhaTransporte(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposPrevidencia(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarHorariosPadrao(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoLogradouro(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosPlanoSaude(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoContrato(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoDeficiencia(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAssistenciaMedica(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAssistenciaOdonto(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarSexo(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAbonoPecuniario(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoFerias(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAlteracaoFamiliar(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarRacaCor(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposVerba(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoLancamento(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarFuncionarioDeficiente(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposDeficiencia(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarContaSalario(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarContratoTrabalho(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse BuscarCategoriaFuncionario(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarCompensacaoSabado(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoEnderecos(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarMaoDeObra(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFiliais(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFuncionariosHabilitados(ConsultaDadoGenericoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
