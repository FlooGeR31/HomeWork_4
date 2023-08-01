using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main()
        {
            Homework1();
            Homework2();
            Homework3();
        }

        /*Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.*/
        static void Homework1()
        {
            Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень B:");
            int B = int.Parse(Console.ReadLine());

            int result = Power(A, B);

            Console.WriteLine($"Число {A} в натуральной степени {B} равно: {result}");
            Console.ReadKey();
        }
        static int Power(int baseNumber, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }


        //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        static void Homework2()
        {
            Console.WriteLine("Введите любое число: ");
            int num = int.Parse(Console.ReadLine());
            int sum = CalcSum(num);
            Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
            Console.ReadKey();
        }

        static int CalcSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        /*Напишите программу, которая задаёт массив из 8 элементов и 
            выводит их на экран. (можно указать любой промежуток)*/

        static void Homework3()
        {
            int[] array = CreateArray(8);

            Console.WriteLine("Элементы массива:");
            PrintArray(array);
            Console.ReadKey();
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = (i + 1) * 2;
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
