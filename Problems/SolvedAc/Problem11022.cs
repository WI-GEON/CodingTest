namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 11022번 문제 - A + B - 8
    /// </summary>
    internal class Problem11022
    {
        public static void Run()
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                var a = int.Parse(inputs[0]);
                var b = int.Parse(inputs[1]);
                Console.WriteLine($"Case #{i}: {a} + {b} = {a + b}");
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => $"Case #{i}: " + string.Join(" ", Console.ReadLine().Split().Select(x => int.Parse(x)).Aggregate((x, y) => (x, y)) + "\n"))));
        }
    }
}
