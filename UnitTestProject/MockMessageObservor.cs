using Receiver.Interface;

namespace UnitTestProject
{


    public class MockMessageObservor : IMessageObservor
    {
        IMessageSubject subject;
        public string Message { get; private set; }

        public MockMessageObservor(IMessageSubject subject)
        {
            this.subject = subject;
        }
        public void Update()
        {

            Message = subject.Message;
        }
    }
}
