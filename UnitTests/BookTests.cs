using BookProduct;

namespace LibraryTests;

public class BookTests
{
    [Fact]
    public void GetInfo_ReturnsFormattedString()
    {
        var book = new Book { Title = "Clean Code", Author = "Robert C. Martin" };
        var result = book.GetInfo();
        Assert.Equal("Clean Code by Robert C. Martin", result);
    }

    [Fact]
    public void GetCharacteristics_ReturnsStaticInfo()
    {
        var book = new Book { Title = "Any", Author = "Any" };
        var result = book.GetCharacteristics();
        Assert.Equal("Hardcover, 300 pages", result);
    }
}

