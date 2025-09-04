namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 1330번 문제 - 두 수 비교하기
    /// </summary>
    internal class Problem1330
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if (A > B)      Console.WriteLine(">");
            else if (A < B) Console.WriteLine("<");
            else            Console.WriteLine("==");

            // Console.WriteLine(A == B ? "==" : (A > B ? ">" : "<"));
        }
    }
}
