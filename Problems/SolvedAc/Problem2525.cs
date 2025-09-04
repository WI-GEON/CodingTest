namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    ///  solved.ac 2525번 문제 - 오븐 시계
    /// </summary>
    internal class Problem2525
    {
        public static void Run()
        {
            var input = Console.ReadLine().Split();
            var H = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            var cookTime = int.Parse(Console.ReadLine());

            M += cookTime;
            if (M >= 60)
            {
                H += M / 60;
                M %= 60;
                if (H >= 24)
                    H %= 24;
            }

            Console.WriteLine($"{H} {M}");
            
            // Console.WriteLine($"{(H + (M + cookTime) / 60) % 24} {(M + cookTime) % 60}");
        }
    }
}
