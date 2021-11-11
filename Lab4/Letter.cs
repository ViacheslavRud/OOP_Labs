namespace Lab4
{
    public class Letter : IDeliverable
    {
        public string DestinationAddress { get; set; }
        
        public string Content { get; set; }
    }
}