
using Receiver.Interface;
using System.Collections.Generic;


namespace UnitTestProject
{
    public class MockReceiver : IMessageSubject,IReceiver
    {
        private List<IMessageObservor> observors = new List<IMessageObservor>();
        public string FakeMessage { get; set; }

        public void Subscribe()
        {
            Message = FakeMessage;
            Notify();
        }
    }
}
