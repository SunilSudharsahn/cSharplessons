namespace LiberA
{
    public class Book
    {
        public String Title = String.Empty;
        public String Author = String.Empty;
        public String Genre = String.Empty;
        public DateTime DateofPublish;
        public int BookPrice;
        public int TotalPages = 350;
        public void OpenBook()
        {
            Console.WriteLine("Book is open");
        }
        public void BookMarkPage(int pageNo)
        {
            Console.WriteLine($"Page No: {pageNo}Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }



    }
}