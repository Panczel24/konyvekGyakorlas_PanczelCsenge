using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace könyvek
{
	internal class Book
	{
		string title;
		string author;
		int pageCount;
		int releaseYear;

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleaseYear { get => releaseYear; }

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public void GetBookByTitle(Book[] books, string title)
		{
			for (int i = 0; i < books.Length; i++)
			{
				if (books[i].Title == title)
				{
                    Console.WriteLine("a könyv amit keresel: " + books[i]);
                }
			}
		}

		public void EditBookData(Book[] books)
		{
            Console.WriteLine("Melyik könyvet akarod módosítani?(1,2,3):  ");
			int valasz = Convert.ToInt32(Console.ReadLine());

			if (valasz == 1)
			{
                Console.WriteLine("Melyik adatot szeretnéd változatni? (cím/szerző/oldalszám/kiadás éve?:  )");
				string mitSzeretne = Console.ReadLine();
				if (mitSzeretne =="cím")
				{
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
					books[0].title = Convert.ToString(Console.ReadLine());
				}
                else if (mitSzeretne == "szerző")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[0].author = Convert.ToString(Console.ReadLine());
                }
                else if (mitSzeretne == "oldalszám")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[0].pageCount = Convert.ToInt16(Console.ReadLine());
                }
                else if (mitSzeretne == "kiadás éve")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[0].releaseYear = Convert.ToInt16(Console.ReadLine());
                }
                else { Console.WriteLine("rosszul  írtál valamit, vagy ilyen opció nincs"); }
                Console.WriteLine("Az új könyv adatai: " + "cím: " + books[0].title + ", szerző: " + books[0].author + ", oldalszám: " + books[0].pageCount + ", kiadás éve: " + books[0].releaseYear);

            }
            else if (valasz == 2)
            {
                Console.WriteLine("Melyik adatot szeretnéd változatni? (cím/szerző/oldalszám/kiadás éve?:  )");
                string mitSzeretne = Console.ReadLine();
                if (mitSzeretne == "cím")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[1].title = Convert.ToString(Console.ReadLine());
                }
                else if(mitSzeretne == "szerző")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[1].author = Convert.ToString(Console.ReadLine());
                }
                else if(mitSzeretne == "oldalszám")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[1].pageCount = Convert.ToInt16(Console.ReadLine());
                }
                else if(mitSzeretne == "kiadás éve")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[1].releaseYear = Convert.ToInt16(Console.ReadLine());
                }
                else { Console.WriteLine("rosszul  írtál valamit, vagy ilyen opció nincs"); }
                Console.WriteLine("Az új könyv adatai: " + "cím: " + books[1].title + ", szerző: " + books[1].author + ", oldalszám: " + books[1].pageCount + ", kiadás éve: " + books[1].releaseYear);

            }
            else if (valasz == 3)
            {
                Console.WriteLine("Melyik adatot szeretnéd változatni? (cím/szerző/oldalszám/kiadás éve?:  )");
                string mitSzeretne = Console.ReadLine();
                if (mitSzeretne == "cím")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[2].title = Convert.ToString(Console.ReadLine());
                }
                else if(mitSzeretne == "szerző")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[2].author = Convert.ToString(Console.ReadLine());
                }
                else if(mitSzeretne == "oldalszám")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[2].pageCount = Convert.ToInt16(Console.ReadLine());
                }
                else if (mitSzeretne == "kiadás éve")
                {
                    Console.WriteLine("Mire szeretnéd megváltozatni?:  ");
                    books[2].releaseYear = Convert.ToInt16(Console.ReadLine());
                }
                else { Console.WriteLine("rosszul  írtál valamit, vagy ilyen opció nincs"); }
                Console.WriteLine("Az új könyv adatai: "+ "cím: "+ books[2].title +", szerző: " + books[2].author + ", oldalszám: "+ books[2].pageCount +", kiadás éve: "+ books[2].releaseYear);
            }            
        }


		public override string? ToString()
		{
			return $"könyv neve: {title}, szerzője: {author}, oldalszáma: {pageCount}, kiadás éve: {releaseYear}"; ;
		}
	}
}
