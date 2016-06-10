using System;
using TMF.FollowME.Application.Contracts;
using TMF.FollowME.Domain.RequestResponse.Tarefa;
using TMF.FollowME.Services.Contratcs;
using TMF.FollowME.Services.Seedwork.ErrorHandlers;
using TMF.FollowME.Services.Seedwork.InstanceProviders;

namespace TMF.FollowME.Services.WCF
{
    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    public class Tarefa : ITarefa
    {
        private readonly ITarefaApp _iTarefaApp;

        public Tarefa(ITarefaApp iTarefaApp)
        {
            if(iTarefaApp == null)
                throw new ArgumentException("_iTarefaApp");
            _iTarefaApp = iTarefaApp;
        }
        public ListarTarefaResponse ListarTarefa(ListarTarefaRequest resquest)
        {
            return _iTarefaApp.ListarTarefa(resquest);
        }
    }
}
