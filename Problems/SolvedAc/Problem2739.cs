namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2739번 문제 - 구구단
    /// </summary>
    internal class Problem2739
    {
        public static void Run()
        {
            var inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{inputNum} * {i} = {inputNum * i}");
            }

            // Enumerable.Range(1, 9).ToList().ForEach(i => Console.WriteLine($"{n} * {i} = {n * i}"));
        }
    }
}
