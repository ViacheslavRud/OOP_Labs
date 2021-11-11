namespace Lab4
{
    public class Shop
    {
        // TODO make constructor that receives IPostalService object and sets it as private field
        private readonly Product[] _products = { new("Fridge"), new("TV"), new("Toaster") };

        public Product[] GetAllProducts()
        {
            return _products;
        }

        public void PlaceOrder(Product product)
        {
            // TODO send order with IPostalService
        }
    }

    public class Product
    {
        public string Name { get; }

        public Product(string name)
        {
            Name = name;
        }
    }

    public class Order : IDeliverable
    {
        // use as example
        public string OrderName { get; set; }
        public string DestinationAddress { get; set; }
    }
}