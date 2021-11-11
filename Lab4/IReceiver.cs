// !!! DO NOT EDIT !!!

namespace Lab4
{
    public interface IReceiver
    {
        string Address { get; }

        void Receive(IDeliverable deliverable);
    }
}