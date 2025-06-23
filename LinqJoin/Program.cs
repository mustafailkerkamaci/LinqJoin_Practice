using LinqJoin;

List<Authors> authors = new List<Authors>
{
    new Authors { AuthorId = 1, Name = "Orhan Pamuk" },
    new Authors { AuthorId = 2, Name = "Elif Safak" },
    new Authors { AuthorId = 3, Name = "Ahmet Umit"}
};

List<Books> books = new List<Books>
{
    new Books { BookId = 1, Title = "Kar", AuthorId = 1 },
    new Books { BookId = 2, Title = "Istanbul", AuthorId = 1 },
    new Books { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
    new Books { BookId = 4, Title = "Beyoglu Rapsodisi", AuthorId = 3 }
};

//Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.
var BookTitleAndAuthorName = from book in books
                             join author in authors on book.AuthorId equals author.AuthorId
                             select new
                             {
                                 book.Title,
                                 author.Name
                             };

foreach (var item in BookTitleAndAuthorName)
{
    Console.WriteLine($"Book Title: {item.Title}, Author Name: {item.Name}");
}