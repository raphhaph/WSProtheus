﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace TMF.Protheus_HRP.Services.Seedwork.InstanceProviders
{
    public class NinjectInstanceProviderServiceBehavior : Attribute, IServiceBehavior
    {
        #region IServiceBehavior Members

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (var item in serviceHostBase.ChannelDispatchers)
            {
                var dispatcher = item as ChannelDispatcher;
                if (dispatcher != null) // add new instance provider for each end point dispatcher
                {
                    dispatcher.Endpoints.ToList().ForEach(endpoint =>
                    {
                        endpoint.DispatchRuntime.InstanceProvider = new NinjectInstanceProvider(serviceDescription.ServiceType);
                    });
                }
            }

        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        #endregion
    }
}