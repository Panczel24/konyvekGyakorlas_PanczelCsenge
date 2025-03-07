namespace könyvek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Book book1 = new Book("The song of Achilles"," Madeline Miller", 252, 2011);
			Book book2 = new Book("Vuk", " Fekete István", 117, 1940);
			Book book3 = new Book("Valami", "Én", 100, 2025);
			Book[] books = [book1, book2, book3];

			Console.WriteLine(book1.ToString());
			Console.WriteLine(book2.ToString());
			Console.WriteLine(book3.ToString());
            Console.WriteLine();
            book1.GetBookByTitle(books, "Vuk");

            Console.WriteLine();
			book1.EditBookData(books);
			//book3.EditBookData(1);
   //         Console.WriteLine("új kiadási évvel: "+ book3.ToString());
        }
	}
}
