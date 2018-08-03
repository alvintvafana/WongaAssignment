namespace Sender
{
    public class MessageSender
    {
        private ISender sender;
        public MessageSender(ISender sender)
        {
            this.sender = sender;
        }
        public void Sender(string message)
        {
            sender.Send(message);
        }
    }
}
