namespace z5
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал заданного числа: {0}", Factorial(n - 2) / Factorial(n - 4));


            int[] arr = new int[5];

            int Factorial(int num)
            {
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    return num * Factorial(num - 1);
                }
            }
        }
    }
}