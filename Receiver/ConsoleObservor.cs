using Receiver.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver
{
    public class ConsoleObservor: IMessageObservor
    {
        IMessageSubject subject;

        public ConsoleObservor(IMessageSubject subject)
        {
            this.subject = subject;
        }
        public void Update()
        {
            Console.WriteLine($"Hello {subject.Message}, I am your father!");
        }
    }
}
