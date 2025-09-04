namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2884번 문제 - 알람 시계
    /// </summary>
    internal class Problem2884
    {
        public static void Run()
        {
            var input = Console.ReadLine().Split();
            var H = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            M -= 45;
            if (M < 0)
            {
                M += 60;
                H -= 1;
                if (H < 0)
                    H = 23;
            }
            Console.WriteLine($"{H} {M}");

            // Console.WriteLine($"{H} == 0 ? 23 : {H} - 1, {M} < 45 ? {M} + 15 : {M} - 45");
        }
    }
}
