namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 2753번 문제 - 윤년
    /// </summary>
    internal class Problem2753
    {
        public static void Run()
        {
            var year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);

            // Console.WriteLine((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? 1 : 0);
        }
    }
}
