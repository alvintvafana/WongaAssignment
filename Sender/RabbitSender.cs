using RabbitMQ.Client;
using System;
using System.Text;

namespace Sender
{
    public class RabbitSender : ISender
    {
        string uri;
        string queueName;

        public RabbitSender(string uri, string queue)
        {
            this.uri = uri;
            queueName = queue;
        }
        

        public void Send(string message=null)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri(uri)
            };
            if(message!=null)
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
                }
            }
        }

       
    }
    
}
