using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Internal
{
    public class MenuManager
    {
        //private ReadingList readingList;
        private ReadingList myReadingList;

        public MenuManager(ReadingList list)
        {
            myReadingList = list;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Додати книгу");
                Console.WriteLine("2. Видалити книгу");
                Console.WriteLine("3. Перевірити книгу в списку");
                Console.WriteLine("4. Показати список книг");
                Console.WriteLine("5. Вийти");

                Console.Write("Виберіть опцію: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть назву книги: ");
                        string title = Console.ReadLine();
                        Console.Write("Введіть автора книги: ");
                        string author = Console.ReadLine();
                        Console.Write("Введіть рік публікації книги: ");
                        int year = int.Parse(Console.ReadLine());
                        Book newBook = new Book(title, author, year);
                        myReadingList.AddBook(newBook);
                        Console.WriteLine($"Книга {title} додана до списку.");
                        break;

                    case "2":
                        Console.Write("Введіть назву книги для видалення: ");
                        string bookTitleToRemove = Console.ReadLine();

                        Book bookToRemove = myReadingList.FindBookByTitle(bookTitleToRemove);

                        if (bookToRemove != null)
                        {
                            myReadingList.RemoveBook(bookToRemove);
                            Console.WriteLine($"{bookToRemove.Title} була видалена зі списку.");
                        }
                        else
                        {
                            Console.WriteLine($"Книга з назвою {bookTitleToRemove} не знайдена в списку.");
                        }
                        break;

                    case "3":
                        Console.Write("Введіть назву книги для перевірки: ");
                        string bookTitleToCheck = Console.ReadLine();

                        bool containsBook = myReadingList.ContainsBookByTitle(bookTitleToCheck);

                        if (containsBook)
                        {
                            Console.WriteLine($"Книга з назвою {bookTitleToCheck} знаходиться у списку.");
                        }
                        else
                        {
                            Console.WriteLine($"Книга з назвою {bookTitleToCheck} не знайдена в списку.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Список книг:");
                        for (int i = 0; i < myReadingList.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {myReadingList[i]}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Дякуємо за використання додатку!");
                        return;

                    default:
                        Console.WriteLine("Невідома опція. Виберіть іншу.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
