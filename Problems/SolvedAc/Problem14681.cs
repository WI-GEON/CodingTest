namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 14681번 문제 - 사분면 고르기
    /// </summary>
    internal class Problem14681
    {
        public static void Run()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)         Console.WriteLine(1);
            else if (x < 0 && y > 0)    Console.WriteLine(2);
            else if (x < 0 && y < 0)    Console.WriteLine(3);
            else if (x > 0 && y < 0)    Console.WriteLine(4);

            // 사분면으로 접근, 좌우? 이후 상하?
            // Console.WriteLine((x > 0 ? (y > 0 ? 1 : 4) : (y > 0 ? 2 : 3)));
        }
    }
}
