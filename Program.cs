using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2calc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the order of numbers is one, two, then modifier");

            Console.WriteLine("write first number");
            string numinstring1 = Console.ReadLine(); // gets the input from user as a string then converts
            int num1 = Int32.Parse(numinstring1);

            Console.WriteLine("write next number");
            string numinstring2 = Console.ReadLine(); // gets the input from user as a string then converts
            int num2 = Int32.Parse(numinstring2);


            Console.WriteLine("enter modifier");  //the modifier is what happens to num 1 and num 2. (2 x 2) x is modifier
            string Mod = Console.ReadLine();
            try {
                if (Mod.Contains("*"))
                { Console.WriteLine("*");
                    Mod = "*";
                    Console.WriteLine(num1 * num2);
                }
                if (Mod.Contains("+"))
                {
                    Mod = "+";
                    Console.WriteLine(num1 + num2);
                }
                if (Mod.Contains("/"))
                {
                    Mod = "/";
                    Console.WriteLine(num1 / num2);
                }
                if (Mod.Contains("-"))
                {
                    Mod = "-";
                    Console.WriteLine(num1 - num2);
                }
            catch (Exception ex)
            { Console.WriteLine("bad"); }
            Console.ReadLine(); 

          
            //num1 is first 
            //modifier is middle
            //num2 is last
            

        }
    }
}
