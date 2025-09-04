namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 25314번 문제 - 코딩은 체육과목 입니다
    /// </summary>
    internal class Problem25314
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int repeatCount = n / 4;
            for (int i = 0; i < repeatCount; i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
            
            /*
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(string.Concat(Enumerable.Repeat("long ", n / 4)) + "int");
            */

            // Console.WriteLine(string.Concat(Enumerable.Repeat("long ", int.Parse(Console.ReadLine()) / 4)) + "int");
        }
    }
}
