using LibraryManagement;

namespace BookProduct;

public class Book : IProduct
{
    public required string Title { get; set; }
    public required string Author { get; set; }

    public string GetInfo() => $"{Title} by {Author}";
    public string GetCharacteristics() => $"Hardcover, 300 pages";
}
