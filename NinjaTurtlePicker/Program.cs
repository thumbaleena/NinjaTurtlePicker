using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string str0 = "Donatello";
            Console.WriteLine(str0.GetHashCode());
            string str00 = "donatello";
            Console.WriteLine(str00.GetHashCode());
            string str000 = "Donnie";
            Console.WriteLine(str000.GetHashCode());
            string str0000 = "donnie";
            Console.WriteLine(str0000.GetHashCode());

            string str1 = "Michaelangelo";
            Console.WriteLine(str1.GetHashCode());
            string str11 = "michaelangelo";
            Console.WriteLine(str11.GetHashCode());
            string str111 = "Mikey";
            Console.WriteLine(str111.GetHashCode());
            string str1111 = "mikey";
            Console.WriteLine(str1111.GetHashCode());

            string str2 = "Leonardo";
            Console.WriteLine(str2.GetHashCode());
            string str22 = "leonardo";
            Console.WriteLine(str22.GetHashCode());
            string str222 = "Leo";
            Console.WriteLine(str222.GetHashCode());
            string str2222 = "leo";
            Console.WriteLine(str2222.GetHashCode());

            string str3 = "Raphael";
            Console.WriteLine(str3.GetHashCode());
            string str33 = "raphael";
            Console.WriteLine(str33.GetHashCode());
            string str333 = "Raph";
            Console.WriteLine(str333.GetHashCode());
            string str3333 = "raph";
            Console.WriteLine(str3333.GetHashCode());

            Hashtable table = new Hashtable();
            table.Add(str0.GetHashCode(), str0);
            table.Add(str00.GetHashCode(), str00);
            table.Add(str000.GetHashCode(), str000);
            table.Add(str0000.GetHashCode(), str0000);
            table.Add(str1.GetHashCode(), str1);
            table.Add(str11.GetHashCode(), str11);
            table.Add(str111.GetHashCode(), str111);
            table.Add(str1111.GetHashCode(), str1111);
            table.Add(str2.GetHashCode(), str2);
            table.Add(str22.GetHashCode(), str22);
            table.Add(str222.GetHashCode(), str222);
            table.Add(str2222.GetHashCode(), str2222);
            table.Add(str3.GetHashCode(), str3);
            table.Add(str33.GetHashCode(), str33);
            table.Add(str333.GetHashCode(), str333);
            table.Add(str3333.GetHashCode(), str3333);

            Console.WriteLine();
            Search(table);
        }

        static void Search(Hashtable HTable)
        {
            Console.WriteLine("Which Ninja Turtle you are looking for?");
            string input = Console.ReadLine();

            if (HTable.ContainsValue(input))
                Console.WriteLine("Found him!");
            else
                Console.WriteLine("Sorry, this is not the turtle you are looking for!");
        }
    }
}