using System;
using System.Collections.Generic;
using System.Linq;

// do not edit
namespace Lab4
{
    public interface IPostalService
    {
        /// <summary>
        /// Takes deliverable and stores until further processing
        /// </summary>
        /// <param name="deliverable"></param>
        void Send(IDeliverable deliverable);

        /// <summary>
        /// Process process all stored deliverables, delivers to actual receivers
        /// </summary>
        void ProcessStored();
    }

    public class PostalService : IPostalService
    {
        private readonly IReceiver[] _receivers;
        private readonly List<IDeliverable> _deliverables = new();

        public PostalService(params IReceiver[] receivers)
        {
            _receivers = receivers;
        }

        public void Send(IDeliverable deliverable)
        {
            _deliverables.Add(deliverable);
        }

        public void ProcessStored()
        {
            for (int i = 0; i < _deliverables.Count; i++)
            {
                var receiver = _receivers.FirstOrDefault(s => s.Address == _deliverables[i].DestinationAddress); // try found receiver with address
                if (receiver == null)
                {
                    Console.WriteLine($"No receiver with address {_deliverables[i].DestinationAddress} found");
                    continue;
                }

                receiver.Receive(_deliverables[i]);
                _deliverables.Remove(_deliverables[i]);
                i--; // one item is removed, index should not increase
            }
        }
    }
}