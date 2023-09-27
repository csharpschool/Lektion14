using Lektion14.Classes;

namespace Lektion14.Services;

public class BookStore
{
    List<Book> _books = new();
    public List<Book> Books => _books.GetRange(0, _books.Count);

    public void AddBook(string title, double price)
    {
        var id = _books.Count == 0 ? 1 : _books.Max(b => b.Id) + 1;
        _books.Add(new Book(id, title, price));
    }

    public void RemoveBook(int id)
    {
        if (!_books.Any(b => b.Id == id)) return;

        var book = _books.Single(b => b.Id == id);
        _books.Remove(book);
    }
}
