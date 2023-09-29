using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04_3rd
{
    internal class HomeLibrary
    {
        private List<Book> library = new List<Book>();

        public void AddBook(Book book)
        {
            library.Add(book);
        }
        public void RemoveBook(Book book)
        {
            library.Remove(book);
        }

        // Метод для поиска книги по автору
        public List<Book> FindBooksByAuthor(string author)
        {
            return library.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //метод для поиска книги по году издания
        public List<Book> FindBooksByYear(int year)
        {
            return library.Where(book => book.Year == year).ToList();
        }

        //Сортировка книги по названию
        public void SortByTitle()
        {
            library.Sort((book1, book2) => string.Compare(book1.Title, book2.Title, StringComparison.OrdinalIgnoreCase));
        }

        //сортировка книг по автору
        public void SortByAuthor()
        {
            library.Sort((book1, book2) => string.Compare(book1.Author, book2.Author, StringComparison.OrdinalIgnoreCase));
        }

        //сортировка по году издания
        public void SortByYear()
        {
            library.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
        }
        //Вывод всех книг в библиотеке
        public void DisplayLibrary()
        {
            Console.WriteLine("Содержимое библиотеки:");
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
