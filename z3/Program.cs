namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы (N): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение элементов матрицы (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение элементов матрицы (b): ");
            int b = int.Parse(Console.ReadLine());

            int[,] massiv = new int[n, n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    massiv[i, j] = random.Next(a, b + 1);
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(massiv);

            int numberCount = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (massiv[i, j] > 0)
                    {
                        numberCount++;
                    }
                }
            }
            Console.WriteLine("Количество положительных чисел: {0}", numberCount);

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += massiv[i, j];
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i + 1) + " строки равна " + sum);
                sum = 0;
            }
            Console.WriteLine();

            static void PrintMatrix(int[,] matrix)
            {
                int n = matrix.GetLength(0);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0, 5}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}