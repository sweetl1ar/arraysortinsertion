using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortinsertion
{
    internal class Program
    {

        static int[] Insertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int j = i;
                while (j > 0 && num < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = num;
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
