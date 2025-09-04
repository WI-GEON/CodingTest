namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2438번 문제 - 별 찍기_1
    /// </summary>
    internal class Problem2438
    {
        public static void Run()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => new string('*', i) + "\n")));
        }
    }
}
