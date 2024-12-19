namespace basics.Models{
    public class Book {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
        public string[]? Type { get; set; }
        public bool isSold { get; set; }

    }
}