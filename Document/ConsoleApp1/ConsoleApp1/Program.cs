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

            bool again = true;
            Console.WriteLine("-----  Document  -----\n");

            do
            {
                Console.WriteLine("Enter the name of the document you would like to create.");

                string docName = Console.ReadLine();

                if (!docName.EndsWith(".txt"))
                {
                    docName += ".txt";  //add .txt to end of filename if it didn't already
                }

                Console.WriteLine("Enter the content of the new document.");

                string docContent = Console.ReadLine();

                try
                {
                    StreamWriter sw = new StreamWriter(docName);

                    sw.WriteLine(docContent);

                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);   //display exceptions
                }
                finally
                {
                    Console.WriteLine("{0} was successfully saved. The document contains {1} characters.",docName, docContent.Length);
                }

                again = GoAgain();  //ask user if they would like to create another file

            } while (again == true);

        }

        static public bool GoAgain()
        {
            Console.WriteLine("\nWould you like to create another file?");
            Console.WriteLine("Y/N:");
            string response = Console.ReadLine();

            switch ( response.ToUpper() )   //Will still accept lowercase responses
            {
                case "Y":
                    return true;
                case "N":
                    Console.WriteLine("Exiting program.");
                    return false;
                default:
                    Console.WriteLine("That is not a valid response. Exiting program.");
                    return false;
            }
        }
    }
}
