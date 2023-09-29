using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04_3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeLibrary myLibrary = new HomeLibrary();

            myLibrary.AddBook(new Book { Title = "Светлая Любовь", Author = "Сабит Муканов", Year = 1931 });
            myLibrary.AddBook(new Book { Title = "Моя борьба", Author = "Адольф Гитлер", Year = 1925 });
            myLibrary.AddBook(new Book { Title = "1984", Author = "Джордж Оруэлл", Year = 1949 });
            myLibrary.AddBook(new Book { Title = "Гарри Поттер и философский камень", Author = "Джоан Роулинг", Year = 1995 });
            myLibrary.AddBook(new Book { Title = "Таинственная история Билли Миллигана", Author = "Дэниел Киз", Year = 1982 });
            myLibrary.AddBook(new Book { Title = "Перси Джексон и последнее пророчество", Author = "Рик Риордан", Year = 2009 });

            myLibrary.DisplayLibrary();

            //Поиск по автору
            string authorToSearch = "Сабит Муканов";
            List<Book> foundBooks = myLibrary.FindBooksByAuthor(authorToSearch);
            Console.WriteLine($"\nКниги автора '{authorToSearch}':");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }

            //Сортировка по названию
            myLibrary.SortByTitle();
            Console.WriteLine("\nСортировка по названию...");
            myLibrary.DisplayLibrary();
        }
    }
}
