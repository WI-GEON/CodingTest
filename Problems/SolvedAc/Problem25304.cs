namespace CodingTest.Problems.SolvedAc
{
    /// <summary>
    /// solved.ac 25304번 문제 - 영수증
    /// </summary>
    internal class Problem25304
    {
        public static void Run()
        {
            var total = int.Parse(Console.ReadLine());
            var itemCount = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < itemCount; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                var price = int.Parse(inputs[0]);
                var quantity = int.Parse(inputs[1]);
                sum += price * quantity;
            }
            if (sum == total)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            // Console.WriteLine(total == Enumerable.Range(0, int.Parse(Console.ReadLine())).Select(_ => Console.ReadLine().Split()).Sum(x => int.Parse(x[0]) * int.Parse(x[1])) ? "Yes" : "No");
        }
    }
}
