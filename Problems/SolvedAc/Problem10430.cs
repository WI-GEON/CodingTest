namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 10430번 문제 - 나머지
    /// </summary>
    internal class Problem10430
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}