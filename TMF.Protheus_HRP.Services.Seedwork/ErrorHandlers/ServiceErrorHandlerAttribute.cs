using System;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;

namespace TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ServiceErrorHandlerAttribute
        : Attribute, IServiceBehavior
    {
        /// <summary>
        ///Provides the ability to pass custom data to binding elements to support the contract implementation
        /// </summary>
        /// <param name="serviceDescription">The service description of the service.</param>
        /// <param name="serviceHostBase">The host of the service.</param>
        /// <param name="endpoints">The service endpoints.</param>
        /// <param name="bindingParameters">The service endpoints.</param>
        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            //not apply for this sample
        }
        /// <summary>
        /// Provides the ability to change run-time property values or insert custom
        /// extension objects such as error handlers, message or parameter interceptors,
        /// security extensions, and other custom extension objects.
        /// </summary>
        /// <param name="serviceDescription">The service description.</param>
        /// <param name="serviceHostBase">The host that is currently being built.</param>
        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            if (serviceHostBase != null && serviceHostBase.ChannelDispatchers.Any())
            {
                //add default error handler to all dispatcher in wcf services
                foreach (ChannelDispatcher dispatcher in serviceHostBase.ChannelDispatchers)
                    dispatcher.ErrorHandlers.Add(new ServiceErrorHandler());
            }
        }
        /// <summary>
        ///  Provides the ability to inspect the service host and the service description
        ///  to confirm that the service can run successfully.
        /// </summary>
        /// <param name="serviceDescription">The service description.</param>
        /// <param name="serviceHostBase">The service host that is currently being constructed.</param>
        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            foreach (ServiceEndpoint se in serviceDescription.Endpoints)
            {
                // Must not examine any metadata endpoint. 
                if (se.Contract.Name.Equals("IMetadataExchange") && se.Contract.Namespace.Equals("http://schemas.microsoft.com/2006/04/mex"))
                    continue;
                foreach (OperationDescription opDesc in se.Contract.Operations)
                {
                    if (opDesc.Faults.Count == 0)
                        throw new InvalidOperationException(String.Format("EnforceServiceErrorBehavior requires a "
                          + "FaultContractAttribute(typeof(ServiceError)) in each operation contract.  "
                          + "The \"{0}\" operation contains no FaultContractAttribute.",
                          opDesc.Name)
                        );
                    bool gfExists = false;
                    foreach (FaultDescription fault in opDesc.Faults)
                    {
                        if (fault.DetailType == typeof(ServiceError))
                            gfExists = true;
                    }
                    if (gfExists == false)
                        throw new InvalidOperationException("EnforceServiceErrorBehavior requires a FaultContractAttribute(typeof(ServiceError)) in an operation contract.");

                }
            }
        }
    }
}
