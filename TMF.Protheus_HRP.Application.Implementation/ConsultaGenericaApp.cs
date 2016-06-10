using System;
using System.Collections.Generic;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using TMF.Protheus_HRP.Application.Crosscutting;
using System.Linq;
using TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class ConsultaGenericaApp : IConsultaGenericaApp
    {
        private readonly IConsultaGenericaDal _iConsultaGenericaDal;

        public ConsultaGenericaApp(IConsultaGenericaDal iConsultaGenericaDal)
        {
            _iConsultaGenericaDal = iConsultaGenericaDal;
        }
        public ConsultaGenericaReponse ListarTiposAdmissao(ListarTiposAdmissaoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposDemissao(ListarTiposDemissaoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarHorarios(ListarHorariosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDepartamentos(ListarDepartamentosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCentroCustoDepartamento(ListarCentroCustoDepartamentoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCentroCusto(ListarCentroCustoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCargos(ListarCargosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarEstadoCivil(ListarEstadoCivilRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarPaises(ListarPaisesRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarUnidadesFederativa(ListarUnidadesFederativaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarGrauInstrucao(ListarGrauInstrucaoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarBancos(ListarBancosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAgencias(ListarAgenciasRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCBO(ListarCBORequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFuncoes(ListarFuncoesRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarUF(ListarUFRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCidades(ListarCidadesRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTurnos(ListarTurnosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarNivelSalario(ListarNivelSalarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAlteracoesSalariais(ListarAlteracoesSalariaisRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarMovtivosAlteracao(ListarMovtivosAlteracaoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarRecebimento(ListarRecebimentoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposVinculoRaiz(ListarTiposVinculoRaizRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarOrgaoRG(ListarOrgaoRGRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarNacionalidades(ListarNacionalidadesRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarSituacaoFuncionario(ListarSituacaoFuncionarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposAfastamento(ListarTiposAfastamentoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarMotivosAfastramento(ListarMotivosAfastramentoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarVerbas(ListarVerbasRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosFolha(ListarCodigosFolhaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarSindicatos(ListarSindicatosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposFuncionario(ListarTiposFuncionarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosLinhaTransporte(ListarCodigosLinhaTransporteRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposPrevidencia(ListarTiposPrevidenciaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTempoAdicional(ListarTempoAdicionalRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarHorariosPadrao(ListarHorariosPadraoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarRegrasApontamentoFuncionario(ListarRegrasApontamentoFuncionarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoLogradouro(ListarTipoLogradouroRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFornecedoresPlanoSaude(ListarFornecedoresPlanoSaudeRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosPlanoSaude(ListarCodigosPlanoSaudeRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoContrato(ListarTipoContratoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoDeficiencia(ListarTipoDeficienciaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAssistenciaMedica(ListarAssistenciaMedicaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAssistenciaOdonto(ListarAssistenciaOdontoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarSexo(ListarSexoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAbonoPecuniario(ListarAbonoPecuniarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoFerias(ListarTipoFeriasRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDependentesAssistenciaMedica(ListarDependentesAssistenciaMedicaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarDependentesAssistenciaOdonto(ListarDependentesAssistenciaOdontoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarAlteracaoFamiliar(ListarAlteracaoFamiliarRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarRacaCor(ListarRacaCorRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposVerba(ListarTiposVerbaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoLancamento(ListarTipoLancamentoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarFuncionarioDeficiente(ChecarFuncionarioDeficienteRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTiposDeficiencia(ListarTiposDeficienciaRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarContaSalario(ListarContaSalarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarContratoTrabalho(ChecarContratoTrabalhoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse BuscarCategoriaFuncionario(BuscarCategoriaFuncionarioRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ChecarCompensacaoSabado(ChecarCompensacaoSabadoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarTipoEnderecos(ListarTipoEnderecosRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarCodigosExposicaoNocivo(ListarCodigosExposicaoNocivoRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarMaoDeObra(ListarMaoDeObraRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFiliais(ListarFiliaisRequest request)
        {
            throw new NotImplementedException();
        }

        public ConsultaGenericaReponse ListarFuncionariosHabilitados(ListarFuncionariosHabilitadosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
