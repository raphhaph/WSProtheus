using System.Collections.Generic;
using TMF.FollowME.Domain.DTO;

namespace TMF.FollowME.DataAccess.Contracts
{
    public interface IClienteAssuntoDal
    {
        ClienteAssunto BuscarClienteAssunto(int idClienteAssunto);
        List<ClienteAssunto> BuscarClienteAssuntoPorFilial(int idFilialMasterData);
        List<ClienteAssunto> BuscarClienteAssuntoPorEmpresa(int idEmpresaMasterData);
        List<ClienteAssunto> BuscarClienteAssuntoPorCliente(int idClienteMasterData);
        ClienteAssunto BuscarClienteAssuntoPorFilial( long idFilialMasterData, int idAssunto);
        ClienteAssunto BuscarClienteAssuntoPorEmpresa(int idEmpresaMasterData, int idAssunto);
        ClienteAssunto BuscarClienteAssuntoPorCliente(int idClienteMasterData, int idAssunto);
    }
}
