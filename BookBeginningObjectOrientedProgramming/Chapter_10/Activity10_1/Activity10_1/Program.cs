using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Executing a Stored Procedure Using a Command Object
            try
            {
                Author author = new Author();
                foreach (string name in author.GetAuthorList(25))
                {
                    Console.WriteLine(name);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            //Using the DataReader Object to Retrieve Records
            /*try
            {
                Author author = new Author();
                foreach (string name in author.GetAuthorList())
                {
                    Console.WriteLine(name);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }*/

            //Creating a Connection and executing SQL Queries
            /*try
            {
                Author author = new Author();
                Console.WriteLine(author.CountAuthors());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }*/
        }
    }
}
