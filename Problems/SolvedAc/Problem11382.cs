namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 11382번 문제 - 꼬마 정민
    /// </summary>
    internal class Problem11382
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            long C = long.Parse(input[2]);
            Console.WriteLine(A + B + C);
        }
    }
}
