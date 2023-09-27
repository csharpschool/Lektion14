namespace Lektion14.Classes
{
    public class Book
    {
        int _id;
        public string Name { get; init; }
        public double Price { get; set; }
        public int Id => _id;

        public Book(int id)
        {
            _id = id;  
        }

        public Book(int id, string name, double price) : this(id)
        {
            Name = name;
            Price = price;
        }
    }
}
