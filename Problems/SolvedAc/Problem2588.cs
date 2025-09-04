namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// soled.ac 2588번 문제 - 곱셈
    /// </summary>
    internal class Problem2588
    {
        public static void Run()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int first = B % 10;
            int second = (B / 10) % 10;
            int third = B / 100;
            Console.WriteLine(A * first);
            Console.WriteLine(A * second);
            Console.WriteLine(A * third);
            Console.WriteLine(A * B);
        }
    }
}
