using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool flag = true;
             int num = 0;
             do
             {
                 try
                 {
                     Console.Write("Enter number: ");
                     num = int.Parse(Console.ReadLine());
                     Console.WriteLine("Your number is: " + generate(num));
                     flag = false;
                 }
                 catch (FormatException fe)
                 {
                     Console.WriteLine("Wrong input " + num);
                 }
                catch(ArithmeticException ae)
                {
                    Console.WriteLine("Wrong input: " + ae.Message);
                }
             } while (flag);

             //Console.WriteLine("Good!");*/

            //  TASK
            /* bool c = true;

             do
             {
                 try
                 {
                     Console.Write("Enter first number: ");
                     int a = int.Parse(Console.ReadLine());

                     Console.Write("Enter second number: ");
                     int b = int.Parse(Console.ReadLine());

                     Console.WriteLine("Result: " + (a / b));

                     c = false;
                 }
                 catch (DivideByZeroException zero)
                 {
                     Console.WriteLine("Wrong! " + zero.Message);
                 }
             } while (c);*/

            //  TASK 2

            byte[] array = generateArray();
            fillArray(array);
            printArray(array);

            Console.ReadLine();
        }

        static int generate(int num)
        {
            int result;
            if (num < 0 || num > 255)
            {
                throw new ArithmeticException();
            }
            else
            {
                Random rand = new Random();
                result = rand.Next(num);
            }
            return result;
        } 

        static byte[] generateArray()
        {
            byte[] result;
            Random rand = new Random();
            result = new byte[rand.Next(1,10)];
            return result;
        }

        static void fillArray(byte[] array)
        {
            Random rand = new Random();
            
            for(int i = 0; i < array.Length; i++)
            {
                int index = rand.Next(-10, 20);
                int value = rand.Next(-200, 200);
                try
                {
                    array[index] = (byte)value;
                }
                catch (IndexOutOfRangeException ie)
                {

                }
                catch (ArgumentOutOfRangeException ae)
                {

                }
            }
        }

        static void printArray(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
