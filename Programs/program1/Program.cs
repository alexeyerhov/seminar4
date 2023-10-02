using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            //3, 5 -> 243 (3⁵)
            //2, 4 -> 16

            void ErectToDegree(double firstNum, double secondNum){
                double reserveFirstNum = firstNum;
                if (secondNum == 0) {
                    Console.WriteLine($"{firstNum} in {secondNum} degree = 1");
                }
                else
                {
                    for (int i = 1; i < secondNum; i++) {
                        firstNum = firstNum * reserveFirstNum;
                    }
                    if (secondNum > 0) {
                    Console.WriteLine($"{reserveFirstNum} in {secondNum} degree = {firstNum}");
                    }
                    else {
                      Console.WriteLine($"{reserveFirstNum} in {secondNum} degree = {1/firstNum}");  
                    }
                }
            }



            //Main code

            Console.WriteLine("Enter a number that need erect to degree: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of degree: ");
            int b = Convert.ToInt32(Console.ReadLine());
            ErectToDegree(a,b);
        }
    }
}
