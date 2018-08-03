using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Receiver.Interface;
using System;
using System.Text;

namespace Receiver
{
    public class RabbitReceiver : IMessageSubject, IReceiver
    {

        ConnectionFactory factory;
        IConnection connection;
        IModel channel;
        string queueName;

        public RabbitReceiver(string uri, string queue)
        {
            queueName = queue;
            factory = new ConnectionFactory() { Uri = new Uri(uri) };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();
        }
        public void Subscribe()
        {



            channel.QueueDeclare(queue: queueName, durable: false,exclusive: false, autoDelete: false,arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                Message =message;
                Notify();

            };
            channel.BasicConsume(queue: queueName,  autoAck: true,consumer: consumer);

        }

        public void Close()
        {
            channel.Close();
            connection.Close();
        }

    }
}
