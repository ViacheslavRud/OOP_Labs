using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // it's an example, delete it
            var shop = new Shop();
            //shop.PlaceOrder();

            // example of postal service usage, 
            var person = new Consumer { Address = "a" };
            var postalService = new PostalService(person);
            postalService.Send(new Order { OrderName = "some order", DestinationAddress = "a" });
            postalService.Send(new Letter { DestinationAddress = "a1", Content = "Hello, Consumer!" });
            postalService.Send(new Letter { DestinationAddress = "a", Content = "Hello, Consumer!2" });
            postalService.ProcessStored();
        }
    }

    public class Consumer : IReceiver
    {
        public void Receive(IDeliverable deliverable)
        {
            // TODO process other types
            switch (deliverable)
            {
                case Letter letter:
                    Console.WriteLine($"Consumer with address \"{Address}\" received letter \"{letter.Content}\" with address \"{letter.DestinationAddress}\"");
                    break;
                default:
                    Console.WriteLine($"Consumer with address \"{Address}\" received unknown deliverable type");
                    break;
            }
        }

        public string Address { get; set; } // TODO set address
    }
}