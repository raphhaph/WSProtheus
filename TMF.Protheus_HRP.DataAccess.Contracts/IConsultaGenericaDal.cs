using System;
using System.Collections.Generic;
using TMF.Protheus_HRP.Domain.DTO;



namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface IConsultaGenericaDal
    {
        List<DadoGenerico> ListarCargos(string pEmpresa, string pFilial);
        List<DadoGenerico> ListarCentroCusto(string pEmpresa, string pFilial, string pCentroCusto);
        List<DadoGenerico> ListarCentroCustoDepartamento(string pEmpresa, string pFilial);
        List<DadoGenerico> BuscarDadosSX5(string pEmpresa, string pFilial,TiposSX5 tipo);
        List<DadoGenerico> ListarBancos(string pEmpresa, string pFilial);
        List<AgenciaBanco> ListarAgenciasBanco(string pCodigoBanco, string pEmpresa, string pFilial);
    }
}
