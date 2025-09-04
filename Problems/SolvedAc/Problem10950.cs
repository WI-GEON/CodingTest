namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 10950번 문제 - A+B - 3
    /// </summary>
    internal class Problem10950
    {
        public static void Run()
        {
            var T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                var input = Console.ReadLine().Split();
                var A = int.Parse(input[0]);
                var B = int.Parse(input[1]);

                Console.WriteLine(A + B);
            }
        }
    }
}
