using System;
using System.ComponentModel.DataAnnotations;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-1, 10);
            Console.WriteLine("Исходный одномерный массив:" + string.Join(";", array));
            int Max = array[0];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Max < array[i])
                {
                    Max = array[i];
                    j = i;
                }
            }
            array[j] = array[0];
            array[0] = Max;

            Console.WriteLine("Измененный массив:" + string.Join(";", array));
        }
    }
}