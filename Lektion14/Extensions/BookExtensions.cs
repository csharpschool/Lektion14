using Lektion14.Classes;

namespace Lektion14.Extensions;

public static class BookExtensions
{
    public static string GetBookData(this Book book) => $"{book.Name}, {book.Price}";

    public static double CalcTotal(this Book book, int count) => book.Price * count;

    public static double CalcVat(this double total, double vat) => total * vat;
}
