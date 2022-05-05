using System;
using System.Collections.Generic;
using SuvillianceSystem.RabbitMQ_Models.Concrete;

namespace SuvillianceSystem.RabbitMQClient.Concrete
{
    public class ConnectorInfo: IConnectorFactoryInfo
    {
        public string Host {get;set;}
    }
}