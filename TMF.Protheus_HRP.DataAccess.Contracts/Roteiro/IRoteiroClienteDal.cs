using System.Collections.Generic;
using TMF.FollowME.Domain.DTO.Roteiro;

namespace TMF.FollowME.DataAccess.Contracts.Roteiro
{
    public interface IRoteiroClienteDal
    {
        List<RoteiroCliente> ListaRoteiroClientes(int idCliente);
        RoteiroCliente ObterRoteiroCliente(int idRoteiroCliente);
        RoteiroCliente ObterRoteiroClienteParaProcesso(int idAssunto, int idFilial, int idTipoDocumento);
    }
}
