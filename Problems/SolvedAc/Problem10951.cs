namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 10951번 문제 - A + B_4
    /// </summary>
    internal class Problem10951
    {
        public static void Run()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] inputs = line.Split();
                var a = int.Parse(inputs[0]);
                var b = int.Parse(inputs[1]);
                Console.WriteLine(a + b);
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.MaxValue).Select(_ => { var inputs = Console.ReadLine()?.Split().Select(x => int.Parse(x)).ToArray(); return (inputs == null) ? null : (inputs[0] + inputs[1]).ToString() + "\n"; }).TakeWhile(x => x != null)));
        }
    }
}
