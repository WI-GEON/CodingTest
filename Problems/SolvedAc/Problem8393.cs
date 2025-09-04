namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 8393번 문제 - 합
    /// </summary>
    internal class Problem8393
    {
        public static void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * (n + 1) / 2); // 등차수열의 합 공식~
        }
    }
}
