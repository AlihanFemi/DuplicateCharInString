using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repeating = new List<char>();
            string str = Console.ReadLine();
            string unique = "";
            foreach(char c in str)
            {
                if (unique.Contains(c))
                    repeating.Add(c);
                else
                    unique += c;
            }
            if(unique.Length > 0)
            {
                Console.WriteLine("Duplicates found! Here are they: ");
                Console.WriteLine(String.Join(", ", repeating));
            }
            else 
                Console.WriteLine("All unique!");
        }
    }
}
