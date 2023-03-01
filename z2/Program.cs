namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-1, 10);
            Console.WriteLine("Исходный одномерный массив:" + string.Join(";", array));

            for (int i = array.Length - 1, j = 0; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
                j++;
                if (j == 6)
                {
                    j = 0;
                    Console.WriteLine("\n");
                }
            }
        }
    }
}