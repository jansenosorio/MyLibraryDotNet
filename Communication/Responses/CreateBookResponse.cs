namespace MyLibraryDotNet.Communication.Responses
{
    public class CreateBookResponse : Book
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public  int QuantityAvailable { get; set; }

    }
}
