namespace CodingTest.Problems.SolvedAc
{
    internal class Problem10952
    {
        public static void Run()
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split();
                var a = int.Parse(inputs[0]);
                var b = int.Parse(inputs[1]);
                if (a == 0 && b == 0)
                    break;
                Console.WriteLine(a + b);
            }

            // Console.WriteLine(string.Concat(Enumerable.Range(1, int.MaxValue).Select(_ => { var inputs = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray(); return (inputs[0] == 0 && inputs[1] == 0) ? null : (inputs[0] + inputs[1]).ToString() + "\n"; }).TakeWhile(x => x != null)));
        }
    }
}
