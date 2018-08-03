using Microsoft.VisualStudio.TestTools.UnitTesting;
using Receiver;
using Sender;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestMessaging
    {
       [TestMethod]
        public void TestSend()
        {
            //Given
            var mockMessage = "Mick";
            var mockSender = new MockSender();
            var messageSender = new MessageSender(mockSender);

            //when
            messageSender.Sender(mockMessage);

            //Then
            Assert.AreEqual(mockMessage, mockSender.Message);
        }
        [TestMethod]
        public void TestReceive()
        {
            //Given
            var receiver = new MockReceiver { FakeMessage=  "Test"  };
            var messageViewer = new MockMessageObservor(receiver);
            receiver.Attach(messageViewer);
            
            var messageReceiver = new MessageReceiver(receiver);


            //when
            messageReceiver.Receive();

            //Then
            Assert.AreEqual("Test", messageViewer.Message);
        }
    }
}
