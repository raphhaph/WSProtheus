using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;

namespace TMF.Protheus_HRP.Application.Contracts
{
    public interface IConsultaGenericaApp
    {

        #region [ SQL ]


        ConsultaGenericaReponse ListarTiposAdmissao(ConsultaDadoGenericoRequest request);


        ConsultaGenericaReponse ListarTiposDemissao(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarHorarios(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarDepartamentos(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCentroCustoDepartamento(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCentroCusto(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCargos(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarEstadoCivil(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarPaises(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarUnidadesFederativa(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarGrauInstrucao(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarBancos(ConsultaDadoGenericoRequest request);

        ListarAgenciasBancoResponse ListarAgenciasBanco(ListarAgenciasRequest request);

        ConsultaGenericaReponse ListarCBO(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarFuncoes(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarUF(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCidades(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTurnos(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarNivelSalario(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarAlteracoesSalariais(ConsultaDadoGenericoRequest request);


        ConsultaGenericaReponse ListarRecebimento(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTiposVinculoRaiz(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarOrgaoRG(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarNacionalidades(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarSituacaoFuncionario(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTiposAfastamento(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarMotivosAfastramento(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarVerbas(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCodigosFolha(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarSindicatos(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTiposFuncionario(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCodigosLinhaTransporte(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTiposPrevidencia(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCodigosAdicionalTempoServico(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarHorariosPadrao(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTipoLogradouro(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarCodigosPlanoSaude(ConsultaDadoGenericoRequest request);

        #endregion

        #region [ DBF ]
        ConsultaGenericaReponse ListarTipoContrato(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarTipoDeficiencia(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarAssistenciaMedica(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarAssistenciaOdonto(ConsultaDadoGenericoRequest request);

        ConsultaGenericaReponse ListarSexo(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarAbonoPecuniario(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarTipoFerias(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarAlteracaoFamiliar(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarRacaCor(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarTiposVerba(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarTipoLancamento(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ChecarFuncionarioDeficiente(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarTiposDeficiencia(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarContaSalario(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ChecarContratoTrabalho(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse BuscarCategoriaFuncionario(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ChecarCompensacaoSabado(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarTipoEnderecos(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarMaoDeObra(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarFiliais(ConsultaDadoGenericoRequest request);



        ConsultaGenericaReponse ListarFuncionariosHabilitados(ConsultaDadoGenericoRequest request);
        #endregion

    }
}
