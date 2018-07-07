using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----  Document  -----\n");
            Console.WriteLine("Enter the name of the document you would like to create.");

            string docName = Console.ReadLine();
            docName += ".txt";  //add .txt to end of filename

            Console.WriteLine("Enter the content of the new document.");

            string docContent = Console.ReadLine();

            try
            {
                StreamWriter sw = new StreamWriter(docName);

                sw.WriteLine(docContent);

                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}
