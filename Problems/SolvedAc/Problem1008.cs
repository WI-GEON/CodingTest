namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 1008번 문제 - A/B
    /// </summary>
    internal class Problem1008
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);

            Console.WriteLine((a / b).ToString("R"));\
        }
    }
}
