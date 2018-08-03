using Receiver.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver
{
   public class MessageReceiver
    {
        private IReceiver receiver;

        public string Message { get; private set; }

        public MessageReceiver(IReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Receive()
        {
            receiver.Subscribe();
        }

    }
}
