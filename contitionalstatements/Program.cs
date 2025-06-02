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
           // ifstatement();
            //ifelse();
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
                Console.WriteLine("a value is greater then b");
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
                Console.WriteLine("a value is greater then b");
            }
            else
            {
                Console.WriteLine("a value is less then b");
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
                Console.WriteLine("a value is greater then b");
            }
            else if(a<b)
            {
                Console.WriteLine("a value is less then b");
            }
            else
            {
                Console.WriteLine("a is equal to b");

            }

        }
    }
    }

