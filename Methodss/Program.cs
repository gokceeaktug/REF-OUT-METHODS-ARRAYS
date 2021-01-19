using System;
using System.Linq;

namespace Methodss
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            int result2 = Add3(ref number1,number2);
            int number3;
            int number4 = 100;
            int result3 = Add4(out number3, number4);

            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(result3);
            Console.WriteLine(number3);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1=20,int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add4(out int number3,int number4)
        {
            number3 = 20;
            return number3 + number4;
        }
        static int Multiply(int number5,int number6)
        {
            return number5 * number6;

        }
        static int Multiply(int number5, int number6,int number7)
        {
            return number5 * number6* number7;

        }
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();

          
        }
    }
}
