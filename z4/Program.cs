namespace z4
{
    class Program
    {
        static int N = 5;

        static void Main()
        {
            int[,] matrix = new int[N, N];
            Random r = new Random();

            int s = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r.Next(1, N);
                    if (j == 1) s *= matrix[i, j];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            if (s / 100 >= 1)
                Console.WriteLine("Произведение элементов второго столбца массива является трехзначным числом.");
            else Console.WriteLine("Произведение элементов второго столбца массива не является трехзначным числом.");
            Console.ReadKey();
        }
    }
}