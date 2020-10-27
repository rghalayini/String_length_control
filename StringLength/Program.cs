using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String length calculator");
            Console.Write("Insert a word or a sentence: ");
            string insertedWord = Console.ReadLine();

            int length = insertedWord.Length;

            //string result = "";

            if (length < 20)
            {
                int starNumber = 20 - length;
                string stars = "";

                for (int i=0; i < starNumber; i++)
                {
                    stars += "*";
                }

                string message = insertedWord + stars;
                Console.WriteLine("The resulting message is: " + message);
            }
            else
            {
                char[] wordArray = insertedWord.ToCharArray();
                Array.Resize(ref wordArray, 20);
                Console.WriteLine(wordArray);
            }
            Console.ReadLine()
        }
    }
}
