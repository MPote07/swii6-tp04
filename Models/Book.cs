namespace TP04.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public string? ISBN { get; set; }
        public int Year { get; set; }
    }
}

// Miguel Pataro CB3021564 e Lucas Vieira CB3020223