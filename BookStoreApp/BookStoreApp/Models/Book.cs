namespace BookStoreApp.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public bool isReserved { get; set; }
        public Nullable<int> ReservationNumber { get; set; }
        public string? ReservedBy { get; set; }
        public Book()
        {

        }
    }
}
