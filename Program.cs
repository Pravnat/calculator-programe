using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_programme
{
    class Program
    {

       static int a;
       static int b;

        public static void Cal()
        {
            Console.WriteLine("enter your operation");
            Console.WriteLine("1.Add 2.Sub 3.Mul 4.div 5.squ 6.cube");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("enter your first number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter yoursecond number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int addition = a + b;
                    Console.WriteLine(addition);
                    break;
                case 2:
                    Console.WriteLine("enter your first number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int sub = a - b;
                    Console.WriteLine(sub);
                    break;
                case 3:
                    Console.WriteLine("enter your first number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int mul = a * b;
                    Console.WriteLine(mul);
                    break;

                case 4:
                    Console.WriteLine("enter your first number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int div = a / b;
                    Console.WriteLine(div);
                    break;
                case 5:
                    Console.WriteLine("enter your  number");
                    a = Convert.ToInt32(Console.ReadLine());
                    

                    int squ = a * a;
                    Console.WriteLine(squ);
                    break;
                case 6:
                    Console.WriteLine("enter your  number");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    int cube = a * a * a;
                    Console.WriteLine(cube);
                    break;

                default:
                    System.Environment.Exit(0);
                    break;
            }
            
                



            
        }
       
        static void Main(string[] args)
        {


            Cal();



        }
    }
}
