using System.Collections.Generic;

namespace Receiver.Interface
{
    public abstract class IMessageSubject
    {
        public string Message { get; protected set; }

        private List<IMessageObservor> observors = new List<IMessageObservor>();
        public void Attach(IMessageObservor observor)
        {
            observors.Add(observor);
        }

        public void Detach(IMessageObservor observor)
        {
            observors.Remove(observor);
        }

        protected void Notify()
        {
            foreach (var item in observors)
                item.Update();
        }
    }
}
