using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace contitionalstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ifstatement();
            ifelse();
            elseifs();

        }
        private static void ifstatement() 
        {
            Console.WriteLine("enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater then {1}",a,b);
            }
        }
        private static void ifelse()
        {
            Console.WriteLine("enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater then {1}",a,b);
            }
            else
            {
                Console.WriteLine("{0} is less then {1}",a,b);
            }
        }
        private static void elseifs()
        {
            Console.WriteLine("enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater then {1}",a,b);
            }
            else if(a<b)
            {
                Console.WriteLine("{0} is less then {1}",a,b);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}",a,b);

            }

        }
    }
    }

