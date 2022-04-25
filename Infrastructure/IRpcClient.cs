using System;

namespace SuvillianceSystem.RabbitMQClient.Infrastructure
{
    public interface IRpcClient
    {
        string Call(string message);
        void Close();
    }
}