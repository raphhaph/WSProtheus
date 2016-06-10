﻿using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;
using TMF.Protheus_HRP.Services.Seedwork.Logging;

namespace TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers
{
    public sealed class ServiceErrorHandler
       : IErrorHandler
    {
        private string _code;
        /// <summary>
        /// Enables error-related processing and returns a value that indicates whether
        /// the dispatcher aborts the session and the instance context in certain cases
        /// </summary>
        /// <remarks>
        /// Trace error and handle this
        /// </remarks>
        /// <param name="error">The exception thrown during processing</param>
        /// <returns>
        /// true if should not abort the session (if there is one) and instance context
        /// if the instance context is not System.ServiceModel.InstanceContextMode.Single;
        /// otherwise, false. The default is false.
        /// </returns>
        public bool HandleError(Exception error)
        {
            LoggerFactory.CurrentLogger.LogException(String.Format("Error code: {0}", _code), error);
            return true;
        }

        /// <summary>
        /// Enables the creation of a custom System.ServiceModel.FaultException{TDetail}
        /// that is returned from an exception in the course of a service method.
        /// </summary>
        /// <param name="error">The System.Exception object thrown in the course of the service operation.</param>
        /// <param name="version">The SOAP version of the message.</param>
        /// <param name="message">The System.ServiceModel.Channels.Message object that is returned to the client, or service in duplex case</param>
        public void ProvideFault(Exception error, MessageVersion version, ref Message message)
        {
            _code = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-fff");
            var errorMessage = String.Format("Ocorreu um erro inesperado. Entre em contato com o administrador e informe o código {0}", _code);
            var fe = new FaultException<ServiceError>(new ServiceError(_code, errorMessage), errorMessage);
            MessageFault fault = fe.CreateMessageFault();
            message = Message.CreateMessage(version, fault, null);

        }

    }
}
