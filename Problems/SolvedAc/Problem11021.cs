namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 11021번 문제 - A + B - 7
    /// </summary>
    internal class Problem11021
    {
        public static void Run()
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                var a = int.Parse(inputs[0]);
                var b = int.Parse(inputs[1]);
                Console.WriteLine($"Case #{i}: {a + b}");
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => $"Case #{i}: " + string.Join(" ", Console.ReadLine().Split().Select(x => int.Parse(x)).Sum() + "\n"))));
        }
    }
}
