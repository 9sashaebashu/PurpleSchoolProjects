using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите название книги! - ");
            string bookName = Console.ReadLine();
            Console.WriteLine($"Введите имя автора книги! - ");
            string author = Console.ReadLine();
            Console.WriteLine($"Введите год издания книги! - ");
            var pubYear = Console.ReadLine(); ;
            Console.WriteLine($"Введите ISBN книги! - ");
            var ISBN = Console.ReadLine();
            
            Console.WriteLine($"\nНазвание книги:{bookName}");
            Console.WriteLine($"Автор:{author}");
            Console.WriteLine($"Год публикации:{pubYear}");
            Console.WriteLine($"ISBN:{ISBN}");

        }
    }
}
