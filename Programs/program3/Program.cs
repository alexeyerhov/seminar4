using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            //6, 1, 33 -> [6, 1, 33]

            void ShowArray(int arraySize){
                Console.Write("[");
                int[] array = new int[arraySize];
                for (int i = 0; i < array.Length; i++){
                    array[i] = new Random().Next(1,10);
                    Console.Write($"{array[i]}, ");
                }
                Console.Write("]");
            }

            
            Console.WriteLine("Введите длину массива :");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            ShowArray(arraySize);
        }
    }
}
