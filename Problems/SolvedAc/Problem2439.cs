namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2439번 문제 - 별 찍기_2
    /// </summary>
    internal class Problem2439
    {
        public static void Run()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => new string(' ', int.Parse(Console.ReadLine()) - i) + new string('*', i) + "\n")));
        }
    }
}
