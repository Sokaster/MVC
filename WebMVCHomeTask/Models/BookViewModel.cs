namespace WebMVCHomeTask.Models
{
    public class BookViewModel
    {
        public BookViewModel(string author, string nameOfBook, int countOfPages)
        {
            Author = author;
            NameOfBook = nameOfBook;
            CountOfPages = countOfPages;
        }

        public string Author { get; set; }
        public string NameOfBook { get; set; }
        public int CountOfPages { get; set; }
    }
}
