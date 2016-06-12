using System.ServiceModel;
using System.ServiceModel.Web;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;

namespace TMF.Protheus_HRP.Services.Contratcs
{
    [ServiceContract]
    public interface IConsultaGenerica
    {
        #region [ Finalizados ]

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarBancos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarBancos(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAgencias")]
        [FaultContract(typeof(ServiceError))]
        ListarAgenciasBancoResponse ListarAgencias(ListarAgenciasRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCodigosAdicionalTempoServico")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosAdicionalTempoServico(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAlteracoesSalariais")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAlteracoesSalariais(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarEstadoCivil")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarEstadoCivil(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarGrauInstrucao")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarGrauInstrucao(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposAfastamento")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposAfastamento(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarNacionalidades")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarNacionalidades(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarOrgaoRG")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarOrgaoRG(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposVinculoRaiz")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposVinculoRaiz(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarRecebimento")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRecebimento(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarSituacaoFuncionario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSituacaoFuncionario(ConsultaDadoGenericoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposAdmissao")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposAdmissao(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposDemissao")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposDemissao(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposFuncionario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposFuncionario(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarUF")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarUF(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCentroCusto")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCentroCusto(ListarCentroCustoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCentroCustoDepartamento")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCentroCustoDepartamento(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCargos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCargos(ConsultaDadoGenericoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCidades")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCidades(ListarCidadesRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCBO")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCBO(ConsultaDadoGenericoRequest request);


        #endregion

        #region [Pendentes]
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarHorarios")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarHorarios(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarDepartamentos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDepartamentos(ConsultaDadoGenericoRequest request);
        
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarPaises")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarPaises(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarUnidadesFederativa")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarUnidadesFederativa(ConsultaDadoGenericoRequest request);
        
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarFuncoes")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFuncoes(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTurnos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTurnos(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarNivelSalario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarNivelSalario(ConsultaDadoGenericoRequest request);







        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarMotivosAfastramento")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarMotivosAfastramento(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarVerbas")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarVerbas(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCodigosFolha")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosFolha(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarSindicatos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSindicatos(ConsultaDadoGenericoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCodigosLinhaTransporte")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosLinhaTransporte(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposPrevidencia")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposPrevidencia(ConsultaDadoGenericoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarHorariosPadrao")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarHorariosPadrao(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarRegrasApontamentoFuncionario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoLogradouro")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoLogradouro(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarFornecedoresPlanoSaude")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCodigosPlanoSaude")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosPlanoSaude(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoContrato")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoContrato(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoDeficiencia")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoDeficiencia(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAssistenciaMedica")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAssistenciaMedica(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAssistenciaOdonto")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAssistenciaOdonto(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarSexo")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarSexo(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAbonoPecuniario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAbonoPecuniario(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoFerias")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoFerias(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarDependentesAssistenciaMedica")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarDependentesAssistenciaOdonto")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarAlteracaoFamiliar")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarAlteracaoFamiliar(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarRacaCor")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarRacaCor(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposVerba")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposVerba(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoLancamento")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoLancamento(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ChecarFuncionarioDeficiente")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarFuncionarioDeficiente(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTiposDeficiencia")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTiposDeficiencia(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarContaSalario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarContaSalario(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ChecarContratoTrabalho")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarContratoTrabalho(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/BuscarCategoriaFuncionario")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse BuscarCategoriaFuncionario(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ChecarCompensacaoSabado")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ChecarCompensacaoSabado(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarTipoEnderecos")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarTipoEnderecos(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarCodigosExposicaoNocivo")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarMaoDeObra")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarMaoDeObra(ConsultaDadoGenericoRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarFiliais")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFiliais(ConsultaDadoGenericoRequest request);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarFuncionariosHabilitados")]
        [FaultContract(typeof(ServiceError))]
        ConsultaGenericaReponse ListarFuncionariosHabilitados(ConsultaDadoGenericoRequest request);

        #endregion
    }
}
