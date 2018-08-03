using System;

namespace Sender
{
    class Program
    {
        static readonly string HOST_URI = "amqp://user:password@192.168.99.100:5672/vhost";
        static readonly string QUEUE_NAME = "myqueue";

        static void Main(string[] args)
        {
        

            var sender = new RabbitSender(HOST_URI, QUEUE_NAME);
            var messageSender = new MessageSender(sender);

            Console.WriteLine("Please write your name");

            var msg = Console.ReadLine();

            messageSender.Sender(msg);

            Console.WriteLine($"You entered {msg}");
            Console.ReadLine();
        }
    }
}
