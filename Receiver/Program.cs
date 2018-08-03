using System;

namespace Receiver
{
    class Program
    {
        static readonly string HOST_URI = "amqp://user:password@192.168.99.100:5672/vhost";
        static readonly string QUEUE_NAME = "myqueue";

        static void Main(string[] args)
        {
            var receiver = new RabbitReceiver(HOST_URI, QUEUE_NAME);
            var messageViewer = new ConsoleObservor(receiver);
            receiver.Attach(messageViewer);

            var messageReceiver = new MessageReceiver(receiver);

            messageReceiver.Receive();

            Console.ReadLine();
            receiver.Close();
        }
    }
}
