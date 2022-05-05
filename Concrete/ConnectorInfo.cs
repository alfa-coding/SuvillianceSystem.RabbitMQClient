using System;
using System.Collections.Generic;
using SuvillianceSystem.RabbitMQClient.Infrastructure;

namespace SuvillianceSystem.RabbitMQClient.Concrete
{
    public class ConnectorInfo: IConnectorFactoryInfo
    {
        public string Host {get;set;}
    }
}