using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
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
        public ConsultaGenericaReponse ListarTiposAdmissao(ListarTiposAdmissaoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposAdmissao(request);
        }
        public ConsultaGenericaReponse ListarTiposDemissao(ListarTiposDemissaoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposDemissao(request);
        }
        public ConsultaGenericaReponse ListarHorarios(ListarHorariosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarHorarios(request);
        }
        public ConsultaGenericaReponse ListarDepartamentos(ListarDepartamentosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDepartamentos(request);
        }
        public ConsultaGenericaReponse ListarCentroCustoDepartamento(ListarCentroCustoDepartamentoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCentroCustoDepartamento(request);
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
        public ConsultaGenericaReponse ListarCargos(ListarCargosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCargos(request);
        }
        public ConsultaGenericaReponse ListarEstadoCivil(ListarEstadoCivilRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarEstadoCivil(request);
        }
        public ConsultaGenericaReponse ListarPaises(ListarPaisesRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarPaises(request);
        }
        public ConsultaGenericaReponse ListarUnidadesFederativa(ListarUnidadesFederativaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarUnidadesFederativa(request);
        }
        public ConsultaGenericaReponse ListarGrauInstrucao(ListarGrauInstrucaoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarGrauInstrucao(request);
        }
        public ConsultaGenericaReponse ListarBancos(ListarBancosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarBancos(request);
        }
        public ConsultaGenericaReponse ListarAgencias(ListarAgenciasRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAgencias(request);
        }
        public ConsultaGenericaReponse ListarCBO(ListarCBORequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCBO(request);
        }
        public ConsultaGenericaReponse ListarFuncoes(ListarFuncoesRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFuncoes(request);
        }
        public ConsultaGenericaReponse ListarUF(ListarUFRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarUF(request);
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
        public ConsultaGenericaReponse ListarTurnos(ListarTurnosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTurnos(request);
        }
        public ConsultaGenericaReponse ListarNivelSalario(ListarNivelSalarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarNivelSalario(request);
        }
        public ConsultaGenericaReponse ListarAlteracoesSalariais(ListarAlteracoesSalariaisRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAlteracoesSalariais(request);
        }
        public ConsultaGenericaReponse ListarMovtivosAlteracao(ListarMovtivosAlteracaoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarMovtivosAlteracao(request);
        }
        public ConsultaGenericaReponse ListarRecebimento(ListarRecebimentoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRecebimento(request);
        }
        public ConsultaGenericaReponse ListarTiposVinculoRaiz(ListarTiposVinculoRaizRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposVinculoRaiz(request);
        }
        public ConsultaGenericaReponse ListarOrgaoRG(ListarOrgaoRGRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarOrgaoRG(request);
        }
        public ConsultaGenericaReponse ListarNacionalidades(ListarNacionalidadesRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarNacionalidades(request);
        }
        public ConsultaGenericaReponse ListarSituacaoFuncionario(ListarSituacaoFuncionarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSituacaoFuncionario(request);
        }
        public ConsultaGenericaReponse ListarTiposAfastamento(ListarTiposAfastamentoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposAfastamento(request);
        }
        public ConsultaGenericaReponse ListarMotivosAfastramento(ListarMotivosAfastramentoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarMotivosAfastramento(request);
        }
        public ConsultaGenericaReponse ListarVerbas(ListarVerbasRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarVerbas(request);
        }
        public ConsultaGenericaReponse ListarCodigosFolha(ListarCodigosFolhaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosFolha(request);
        }
        public ConsultaGenericaReponse ListarSindicatos(ListarSindicatosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSindicatos(request);
        }
        public ConsultaGenericaReponse ListarTiposFuncionario(ListarTiposFuncionarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposFuncionario(request);
        }
        public ConsultaGenericaReponse ListarCodigosLinhaTransporte(ListarCodigosLinhaTransporteRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosLinhaTransporte(request);
        }
        public ConsultaGenericaReponse ListarTiposPrevidencia(ListarTiposPrevidenciaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposPrevidencia(request);
        }
        public ConsultaGenericaReponse ListarTempoAdicional(ListarTempoAdicionalRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTempoAdicional(request);
        }
        public ConsultaGenericaReponse ListarHorariosPadrao(ListarHorariosPadraoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarHorariosPadrao(request);
        }
        public ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ListarRegrasApontamentoFuncionarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRegrasApontamentoFuncionario(request);
        }
        public ConsultaGenericaReponse ListarTipoLogradouro(ListarTipoLogradouroRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoLogradouro(request);
        }
        public ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ListarFornecedoresPlanoSaudeRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFornecedoresPlanoSaude(request);
        }
        public ConsultaGenericaReponse ListarCodigosPlanoSaude(ListarCodigosPlanoSaudeRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosPlanoSaude(request);
        }
        public ConsultaGenericaReponse ListarTipoContrato(ListarTipoContratoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoContrato(request);
        }
        public ConsultaGenericaReponse ListarTipoDeficiencia(ListarTipoDeficienciaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoDeficiencia(request);
        }
        public ConsultaGenericaReponse ListarAssistenciaMedica(ListarAssistenciaMedicaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAssistenciaMedica(request);
        }
        public ConsultaGenericaReponse ListarAssistenciaOdonto(ListarAssistenciaOdontoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAssistenciaOdonto(request);
        }
        public ConsultaGenericaReponse ListarSexo(ListarSexoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarSexo(request);
        }
        public ConsultaGenericaReponse ListarAbonoPecuniario(ListarAbonoPecuniarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAbonoPecuniario(request);
        }
        public ConsultaGenericaReponse ListarTipoFerias(ListarTipoFeriasRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoFerias(request);
        }
        public ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ListarDependentesAssistenciaMedicaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDependentesAssistenciaMedica(request);
        }
        public ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ListarDependentesAssistenciaOdontoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarDependentesAssistenciaOdonto(request);
        }
        public ConsultaGenericaReponse ListarAlteracaoFamiliar(ListarAlteracaoFamiliarRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarAlteracaoFamiliar(request);
        }
        public ConsultaGenericaReponse ListarRacaCor(ListarRacaCorRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarRacaCor(request);
        }
        public ConsultaGenericaReponse ListarTiposVerba(ListarTiposVerbaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                }; return _iConsultaGenericaApp.ListarTiposVerba(request);
        }
        public ConsultaGenericaReponse ListarTipoLancamento(ListarTipoLancamentoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoLancamento(request);
        }
        public ConsultaGenericaReponse ChecarFuncionarioDeficiente(ChecarFuncionarioDeficienteRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse { BusinessErrors = new List<string>() { Messages.ErroAutenticacao }, }
                    ;
            return _iConsultaGenericaApp.ChecarFuncionarioDeficiente(request);
        }
        public ConsultaGenericaReponse ListarTiposDeficiencia(ListarTiposDeficienciaRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTiposDeficiencia(request);
        }
        public ConsultaGenericaReponse ListarContaSalario(ListarContaSalarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse { BusinessErrors = new List<string>() { Messages.ErroAutenticacao }, }
                    ;
            return _iConsultaGenericaApp.ListarContaSalario(request);
        }
        public ConsultaGenericaReponse ChecarContratoTrabalho(ChecarContratoTrabalhoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ChecarContratoTrabalho(request);
        }
        public ConsultaGenericaReponse BuscarCategoriaFuncionario(BuscarCategoriaFuncionarioRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.BuscarCategoriaFuncionario(request);
        }
        public ConsultaGenericaReponse ChecarCompensacaoSabado(ChecarCompensacaoSabadoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ChecarCompensacaoSabado(request);
        }
        public ConsultaGenericaReponse ListarTipoEnderecos(ListarTipoEnderecosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarTipoEnderecos(request);
        }
        public ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ListarCodigosExposicaoNocivoRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarCodigosExposicaoNocivo(request);
        }
        public ConsultaGenericaReponse ListarMaoDeObra(ListarMaoDeObraRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarMaoDeObra(request);
        }
        public ConsultaGenericaReponse ListarFiliais(ListarFiliaisRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFiliais(request);
        }
        public ConsultaGenericaReponse ListarFuncionariosHabilitados(ListarFuncionariosHabilitadosRequest request)
        {
            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ConsultaGenericaReponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };
            return _iConsultaGenericaApp.ListarFuncionariosHabilitados(request);
        }

    }
}
