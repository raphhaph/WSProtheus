using Ninject;
using Ninject.Web.Common;
using System;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Application.Implementation;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.DataAccess.Implementation;
using TMF.Protheus_HRP.Infrastructure.Common.Logging;
using TMF.Protheus_HRP.Services.Seedwork.Logging;

namespace TMF.Protheus_HRP.Services.Seedwork.InstanceProviders
{
    public static class Container
    {
        static IKernel _currentContainer;
        static Container()
        {
            ConfigureContainer();
            ConfigureFactories();
        }
        static void ConfigureContainer()
        {
            _currentContainer = new StandardKernel();
           
            _currentContainer.Bind<ICabFuncApp>().To<CabFunApp>();
            _currentContainer.Bind<ICabFunDal>().To<CabFunDal>().WithConstructorArgument("connectionName", "TMF_Protheus");

            _currentContainer.Bind<IConsultaGenericaApp>().To<ConsultaGenericaApp>();
            _currentContainer.Bind<IConsultaGenericaDal>().To<ConsultaGenericaDal>().WithConstructorArgument("connectionName", "TMF_Protheus");


            _currentContainer.Bind<IDemonstrativoApp>().To<DemonstrativoApp>();
            _currentContainer.Bind<IDemonstrativoDal>().To<DemonstrativoDal>().WithConstructorArgument("connectionName", "TMF_Protheus");
            #region Logging Configuration
            _currentContainer.Bind<ILogger>().To<NLogLogger>();
            #endregion
        }
        static void ConfigureFactories()
        {
            var logger = _currentContainer.Get<ILogger>();
            LoggerFactory.SetCurrent(logger);
        }
        public static object GetInstance(Type serviceType)
        {
            return _currentContainer.Get(serviceType);
        }
        public static T GetInstance<T>()
        {
            return _currentContainer.Get<T>();
        }
    }
}
