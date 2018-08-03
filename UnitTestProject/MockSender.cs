
using Sender;

namespace UnitTestProject
{
    public class MockSender : ISender
    {
        public string Message { get; set; }
        public void Send(string message=null)
        {
            this.Message = message;
        }
    }
}
