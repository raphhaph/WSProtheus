using System.Collections.Generic;
using System.ServiceModel;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;
using TMF.Protheus_HRP.Resources;
using TMF.Protheus_HRP.Services.Contratcs;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF_Rest
{

    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ConsultaGenerica : BaseInstanceProvider, IConsultaGenerica
    {
        private readonly IConsultaGenericaApp _iConsultaGenericaApp;
        public ConsultaGenerica(IConsultaGenericaApp iApp)
        {
            _iConsultaGenericaApp = iApp;
        }

        #region [Finalizados]
        public ConsultaGenericaReponse ListarTiposAdmissao(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposAdmissao(request);
        }
        public ConsultaGenericaReponse ListarTiposDemissao(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposDemissao(request);
        }
        public ConsultaGenericaReponse ListarCodigosAdicionalTempoServico(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosAdicionalTempoServico(request);
        }
        public ConsultaGenericaReponse ListarAlteracoesSalariais(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAlteracoesSalariais(request);
        }
        public ConsultaGenericaReponse ListarEstadoCivil(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarEstadoCivil(request);
        }
        public ConsultaGenericaReponse ListarGrauInstrucao(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarGrauInstrucao(request);
        }
        public ConsultaGenericaReponse ListarTiposAfastamento(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposAfastamento(request);
        }
        public ConsultaGenericaReponse ListarNacionalidades(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarNacionalidades(request);
        }
        public ConsultaGenericaReponse ListarOrgaoRG(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarOrgaoRG(request);
        }
        public ConsultaGenericaReponse ListarTiposVinculoRaiz(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposVinculoRaiz(request);
        }
        public ConsultaGenericaReponse ListarRecebimento(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRecebimento(request);
        }
        public ConsultaGenericaReponse ListarSituacaoFuncionario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSituacaoFuncionario(request);
        }
        public ConsultaGenericaReponse ListarTiposFuncionario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposFuncionario(request);
        }
        public ConsultaGenericaReponse ListarUF(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarUF(request);
        }
        public ConsultaGenericaReponse ListarBancos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarBancos(request);
        }
        public ListarAgenciasBancoResponse ListarAgencias(ListarAgenciasRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ListarAgenciasBancoResponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAgenciasBanco(request);
        }
        public ConsultaGenericaReponse ListarCentroCusto(ListarCentroCustoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCentroCusto(request);
        }
        public ConsultaGenericaReponse ListarDepartamentos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDepartamentos(request);
        }
        public ConsultaGenericaReponse ListarCargos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCargos(request);
        }
        public ConsultaGenericaReponse ListarCBO(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCBO(request);
        }
        public ConsultaGenericaReponse ListarCidades(ListarCidadesRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCidades(request);
        }


        #endregion

        #region [Pendentes]
        public ConsultaGenericaReponse ListarHorarios(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarHorarios(request);
        }
        public ConsultaGenericaReponse ListarCentroCustoDepartamento(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCentroCustoDepartamento(request);
        }
      
        public ConsultaGenericaReponse ListarPaises(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarPaises(request);
        }
        public ConsultaGenericaReponse ListarUnidadesFederativa(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarUnidadesFederativa(request);
        }
        public ConsultaGenericaReponse ListarFuncoes(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFuncoes(request);
        }
     
        public ConsultaGenericaReponse ListarTurnos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTurnos(request);
        }
        public ConsultaGenericaReponse ListarNivelSalario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarNivelSalario(request);
        }
        public ConsultaGenericaReponse ListarMotivosAfastramento(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarMotivosAfastramento(request);
        }
        public ConsultaGenericaReponse ListarVerbas(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarVerbas(request);
        }
        public ConsultaGenericaReponse ListarCodigosFolha(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosFolha(request);
        }
        public ConsultaGenericaReponse ListarSindicatos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSindicatos(request);
        }
        public ConsultaGenericaReponse ListarCodigosLinhaTransporte(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosLinhaTransporte(request);
        }
        public ConsultaGenericaReponse ListarTiposPrevidencia(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposPrevidencia(request);
        }
        public ConsultaGenericaReponse ListarHorariosPadrao(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarHorariosPadrao(request);
        }
        public ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRegrasApontamentoFuncionario(request);
        }
        public ConsultaGenericaReponse ListarTipoLogradouro(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoLogradouro(request);
        }
        public ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFornecedoresPlanoSaude(request);
        }
        public ConsultaGenericaReponse ListarCodigosPlanoSaude(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosPlanoSaude(request);
        }
        public ConsultaGenericaReponse ListarTipoContrato(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoContrato(request);
        }
        public ConsultaGenericaReponse ListarTipoDeficiencia(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoDeficiencia(request);
        }
        public ConsultaGenericaReponse ListarAssistenciaMedica(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAssistenciaMedica(request);
        }
        public ConsultaGenericaReponse ListarAssistenciaOdonto(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAssistenciaOdonto(request);
        }
        public ConsultaGenericaReponse ListarSexo(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSexo(request);
        }
        public ConsultaGenericaReponse ListarAbonoPecuniario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAbonoPecuniario(request);
        }
        public ConsultaGenericaReponse ListarTipoFerias(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoFerias(request);
        }
        public ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDependentesAssistenciaMedica(request);
        }
        public ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDependentesAssistenciaOdonto(request);
        }
        public ConsultaGenericaReponse ListarAlteracaoFamiliar(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAlteracaoFamiliar(request);
        }
        public ConsultaGenericaReponse ListarRacaCor(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRacaCor(request);
        }
        public ConsultaGenericaReponse ListarTiposVerba(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                }; return _iConsultaGenericaApp.ListarTiposVerba(request);
        }
        public ConsultaGenericaReponse ListarTipoLancamento(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoLancamento(request);
        }
        public ConsultaGenericaReponse ChecarFuncionarioDeficiente(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse { BusinessErrors = new List<string>() { Messages.ErroAutenticacao }, }
                    ;
            return _iConsultaGenericaApp.ChecarFuncionarioDeficiente(request);
        }
        public ConsultaGenericaReponse ListarTiposDeficiencia(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposDeficiencia(request);
        }
        public ConsultaGenericaReponse ListarContaSalario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse { BusinessErrors = new List<string>() { Messages.ErroAutenticacao }, }
                    ;
            return _iConsultaGenericaApp.ListarContaSalario(request);
        }
        public ConsultaGenericaReponse ChecarContratoTrabalho(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ChecarContratoTrabalho(request);
        }
        public ConsultaGenericaReponse BuscarCategoriaFuncionario(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.BuscarCategoriaFuncionario(request);
        }
        public ConsultaGenericaReponse ChecarCompensacaoSabado(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ChecarCompensacaoSabado(request);
        }
        public ConsultaGenericaReponse ListarTipoEnderecos(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoEnderecos(request);
        }
        public ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosExposicaoNocivo(request);
        }
        public ConsultaGenericaReponse ListarMaoDeObra(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarMaoDeObra(request);
        }
        public ConsultaGenericaReponse ListarFiliais(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFiliais(request);
        }
        public ConsultaGenericaReponse ListarFuncionariosHabilitados(ConsultaDadoGenericoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFuncionariosHabilitados(request);
        }
        #endregion
    }
}
