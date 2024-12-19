namespace basics.Models
{
    public class Repository 
    {
        private static readonly List<Book> _books = new();

        static Repository () 
        {
            _books = new List<Book>()
            {
                  new Book() 
            {
                Id=1, Title="Lord Of The Rings",  
                Author="J.R.R. Tolkien",
                Description="Book summary...",
                Image="ring.jpg", 
                Price=608.55,
                Type = new string[] {"fantastic","adventure", "science fiction"},
                isSold = true
            },

            new Book() 
            {
                Id=2, Title="1984",  
                Author="George Orwell",
                Description="Book summary...",
                Image="1984.jpg", 
                Price=326.90,
                Type = new string[] {"dystopian fiction","political fiction", "science fiction"},
                isSold = true
            },

            new Book() 
            {
                Id=3, Title="Meditations",  
                Author="Marcus Aurelius",
                Description="Book summary...",
                Image="meditations.jpg", 
                Price=450.50,
                Type = new string[] {"philosophy"},
                isSold = false
            },  
            
            new Book() 
            {
                Id=4, Title="War And Peace",  
                Author="Leo Tolstyoe",
                Description="Book summary...",
                Image="peace.jpg", 
                Price=256.90,
                Type = new string[] {"historical novel"},
                isSold = true
            },    

             new Book() {
                Id=5, Title="Ethics",  
                Author="Spinoza",
                Description="Book summary...",
                Image="ethics.jpg", 
                Price=145.80,
                Type = new string[] {"examination"},
                isSold = false
            },    

            new Book() 
            {
                Id=6, Title="Crime And Punishment",  
                Author="Fyodor Dostoyevsky",
                Description="Book summary...",
                Image="crime.jpg", 
                Price=250.90,
                Type = new string[] {"novel"},
                isSold = true
            },       
            };
        }
        public static List<Book> Books 
        {
            get
            {
                return _books;
            }
        }

        public static Book? GetById(int? id) 
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

    }
}