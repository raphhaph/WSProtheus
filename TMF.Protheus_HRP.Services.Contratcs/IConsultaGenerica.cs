using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;

namespace TMF.Protheus_HRP.Services.Contratcs
{
    [ServiceContract]
    public interface IConsultaGenerica
    {
        #region [ SQL ]
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarNivelSalarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposAdmissao(ListarTiposAdmissaoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarAlteracoesSalariaisRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposDemissao(ListarTiposDemissaoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarMovtivosAlteracaoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarHorarios(ListarHorariosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarRecebimentoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDepartamentos(ListarDepartamentosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposVinculoRaizRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCentroCustoDepartamento(ListarCentroCustoDepartamentoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarOrgaoRGRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCentroCusto(ListarCentroCustoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarNacionalidadesRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCargos(ListarCargosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarSituacaoFuncionarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarEstadoCivil(ListarEstadoCivilRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposAfastamentoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarPaises(ListarPaisesRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarMotivosAfastramentoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarUnidadesFederativa(ListarUnidadesFederativaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarVerbasRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarGrauInstrucao(ListarGrauInstrucaoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarSindicatosRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarBancos(ListarBancosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposFuncionarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAgencias(ListarAgenciasRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCodigosLinhaTransporteRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCBO(ListarCBORequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposPrevidenciaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFuncoes(ListarFuncoesRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTempoAdicionalRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarUF(ListarUFRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarHorariosPadraoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCidades(ListarCidadesRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarRegrasApontamentoFuncionarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTurnos(ListarTurnosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoLogradouroRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarNivelSalario(ListarNivelSalarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarFornecedoresPlanoSaudeRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAlteracoesSalariais(ListarAlteracoesSalariaisRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCodigosPlanoSaudeRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarMovtivosAlteracao(ListarMovtivosAlteracaoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoContratoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRecebimento(ListarRecebimentoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoDeficienciaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposVinculoRaiz(ListarTiposVinculoRaizRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarAssistenciaMedicaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarOrgaoRG(ListarOrgaoRGRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarAssistenciaOdontoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarNacionalidades(ListarNacionalidadesRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarSexoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSituacaoFuncionario(ListarSituacaoFuncionarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarAbonoPecuniarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposAfastamento(ListarTiposAfastamentoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoFeriasRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarMotivosAfastramento(ListarMotivosAfastramentoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarDependentesAssistenciaMedicaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarVerbas(ListarVerbasRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarDependentesAssistenciaOdontoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosFolha(ListarCodigosFolhaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarAlteracaoFamiliarRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSindicatos(ListarSindicatosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarRacaCorRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposFuncionario(ListarTiposFuncionarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposVerbaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosLinhaTransporte(ListarCodigosLinhaTransporteRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoLancamentoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposPrevidencia(ListarTiposPrevidenciaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ChecarFuncionarioDeficienteRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTempoAdicional(ListarTempoAdicionalRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTiposDeficienciaRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarHorariosPadrao(ListarHorariosPadraoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarContaSalarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ListarRegrasApontamentoFuncionarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ChecarContratoTrabalhoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoLogradouro(ListarTipoLogradouroRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/BuscarCategoriaFuncionarioRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ListarFornecedoresPlanoSaudeRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ChecarCompensacaoSabadoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosPlanoSaude(ListarCodigosPlanoSaudeRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarTipoEnderecosRequest")]
        [FaultContract(typeof(ServiceError))]
        #endregion

        #region [ DBF ]
        ConsultaGenericaReponse ListarTipoContrato(ListarTipoContratoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCodigosExposicaoNocivoRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoDeficiencia(ListarTipoDeficienciaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarMaoDeObraRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAssistenciaMedica(ListarAssistenciaMedicaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarFiliaisRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAssistenciaOdonto(ListarAssistenciaOdontoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarFuncionariosHabilitadosRequest")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSexo(ListarSexoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAbonoPecuniario(ListarAbonoPecuniarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoFerias(ListarTipoFeriasRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ListarDependentesAssistenciaMedicaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ListarDependentesAssistenciaOdontoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAlteracaoFamiliar(ListarAlteracaoFamiliarRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRacaCor(ListarRacaCorRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposVerba(ListarTiposVerbaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoLancamento(ListarTipoLancamentoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarFuncionarioDeficiente(ChecarFuncionarioDeficienteRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposDeficiencia(ListarTiposDeficienciaRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarContaSalario(ListarContaSalarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarContratoTrabalho(ChecarContratoTrabalhoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse BuscarCategoriaFuncionario(BuscarCategoriaFuncionarioRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarCompensacaoSabado(ChecarCompensacaoSabadoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoEnderecos(ListarTipoEnderecosRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ListarCodigosExposicaoNocivoRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarMaoDeObra(ListarMaoDeObraRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFiliais(ListarFiliaisRequest request);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFuncionariosHabilitados(ListarFuncionariosHabilitadosRequest request);
        #endregion

    }
}
