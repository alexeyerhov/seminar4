using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452 -> 11
            //82 -> 10
            //9012 -> 12

            void SumOfSymbolsInNumber(int num){
                int sum = 0;
                while (num > 0) {
                    sum += num%10;
                    num/=10;
                }
                Console.WriteLine(Convert.ToString(sum));
            }

            Console.WriteLine("Введите число :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0) {
                number *= -1;
            }
            SumOfSymbolsInNumber(number);



        }
    }
}
