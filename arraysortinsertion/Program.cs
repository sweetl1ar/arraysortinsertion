using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortinsertion
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int num = a;
            a = b;
            b = num;
        }

        static int[] Insertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int c = array[i];
                int d = i;

                while ((d > 0) && (array[d - 1] > c)) 
                {
                    Swap(ref array[d - 1], ref array[d]);
                    d--;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Insertion(array);

            Console.WriteLine();
            Console.WriteLine("Массив после сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
