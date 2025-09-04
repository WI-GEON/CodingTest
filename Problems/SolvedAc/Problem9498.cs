namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 9498번 문제 - 시험 성적
    /// </summary>
    internal class Problem9498
    {
        public static void Run()
        {
            var score = int.Parse(Console.ReadLine());
            if (score >= 90)       Console.WriteLine("A");
            else if (score >= 80)  Console.WriteLine("B");
            else if (score >= 70)  Console.WriteLine("C");
            else if (score >= 60)  Console.WriteLine("D");
            else                   Console.WriteLine("F");
        }
    }
}
