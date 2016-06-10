using System.Configuration;
using System.ServiceModel;

namespace TMF.Protheus_HRP.Application.Implementation
{
    public class ServiceUtil
    {
        public static T CreateChannel<T>(string endpoint) where T : class
        {
            ClientBase<T>.CacheSetting = CacheSetting.AlwaysOn;
            var factory = new ChannelFactory<T>(endpoint);

            if (factory.Credentials == null) return factory.CreateChannel();
            factory.Credentials.UserName.UserName = ConfigurationManager.AppSettings["ServiceUser"];
            factory.Credentials.UserName.Password = ConfigurationManager.AppSettings["ServiceUserPwd"];

            return factory.CreateChannel();
        }
    }
}