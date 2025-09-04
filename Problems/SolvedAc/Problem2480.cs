namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2480번 문제 - 주사위 세개
    /// </summary>
    internal class Problem2480
    {
        public static void Run()
        {
            var input = Console.ReadLine().Split();
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);
            var c = int.Parse(input[2]);

            Console.WriteLine(GetSameCount(a, b, c) switch
            {
                3 => 10000 + a * 1000,
                2 => 1000 + (a == b ? a : c) * 100,
                _ => Math.Max(a, Math.Max(b, c)) * 100
            });
        }

        /// <summary>
        /// 같은 주사위 개수 반환
        /// </summary>
        static int GetSameCount(int a, int b, int c)
        {
            if (a == b && b == c)
                return 3;
            else if (a == b || a == c || b == c)
                return 2;
            else
                return 0;
        }
    }
}
