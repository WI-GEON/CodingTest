namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 10869번 문제 - 사칙연산
    /// </summary>
    internal class Problem10869
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
