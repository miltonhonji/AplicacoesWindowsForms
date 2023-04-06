using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBooksSold();
            //GetTitles();
            //GetTitlesByPrice();
        }

        private static void GetBooksSold()
        {
            var context = new pubsEntities();
            var query = from b in context.books
                        select new
                        {
                            BookId = b.title_id,
                            TotalSold = b.sales.Sum(s => (int?)s.qty)
                        };

            foreach (var item in query)
            {
                Console.WriteLine(item.BookId + " -- " + item.TotalSold);
            }
            Console.ReadLine();
        }

        private static void GetTitles()
        {
            var context = new pubsEntities();
            var query = from b in context.books select b;
            var books = query.ToList();

            foreach (book b in books)
            {
                Console.WriteLine(b.title);
            }

            Console.ReadLine();
        }

        private static void GetTitlesByPrice()
        {
            var context = new pubsEntities();
            var query = from b in context.books
                        where b.price >= (decimal)10.00
                              && b.price <= (decimal)20.00
                        orderby b.price
                        select b;
            var books = query.ToList();

            foreach(book b in books)
            {
                Console.WriteLine(b.price + " -- " + b.title);
            }
            Console.ReadLine();
        }
    }
}
