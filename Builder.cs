namespace CodingTest
{
    internal static class ProblemsIndex
    {
        // 한 곳에서만 관리: 파일 추가 시 여기만 업데이트
        internal static readonly IReadOnlyDictionary<int, Action> Map = new Dictionary<int, Action>
        {
            [1008] = Problems.SolvedAc.Problem1008.Run,
            [10869] = Problems.SolvedAc.Problem10869.Run,
            [10926] = Problems.SolvedAc.Problem10926.Run,
            [18108] = Problems.SolvedAc.Problem18108.Run,
            [10430] = Problems.SolvedAc.Problem10430.Run,
            [2588] = Problems.SolvedAc.Problem2588.Run,
            [11382] = Problems.SolvedAc.Problem11382.Run,
            [1330] = Problems.SolvedAc.Problem1330.Run,
            [9498] = Problems.SolvedAc.Problem9498.Run,
            [2753] = Problems.SolvedAc.Problem2753.Run,
            [14681] = Problems.SolvedAc.Problem14681.Run,
            [2884] = Problems.SolvedAc.Problem2884.Run,
            [2525] = Problems.SolvedAc.Problem2525.Run,
            [2480] = Problems.SolvedAc.Problem2480.Run,
            [2739] = Problems.SolvedAc.Problem2739.Run,
            [10950] = Problems.SolvedAc.Problem10950.Run,
            [8393] = Problems.SolvedAc.Problem8393.Run,
            [25304] = Problems.SolvedAc.Problem25304.Run,
            [25314] = Problems.SolvedAc.Problem25314.Run,
            [11021] = Problems.SolvedAc.Problem11021.Run,
            [11022] = Problems.SolvedAc.Problem11022.Run,
            [2438] = Problems.SolvedAc.Problem2438.Run,
            [10952] = Problems.SolvedAc.Problem10952.Run,
            [10951] = Problems.SolvedAc.Problem10951.Run,
        };

        internal static void PrintList()
        {
            Console.WriteLine($"등록 문제 ({Map.Count}개):");
            int col = 0;
            foreach (var id in Map.Keys)
            {
                Console.Write($"{id,6}");
                if (++col % 10 == 0) Console.WriteLine();
            }
            if (col % 10 != 0) Console.WriteLine();
        }
    }

    internal static class ConsoleUi
    {
        internal const string Prompt = "문제 번호 또는 명령(list/help/repeat/clear/exit): ";

        internal static void PrintHelp()
        {
            Console.WriteLine(
@"사용법
- 숫자: 해당 문제 실행 (예: 1008)
- list : 등록된 문제 목록 보기
- repeat : 마지막으로 실행한 문제 다시 실행
- clear : 화면 지우기
- help : 도움말
- exit : 종료");
        }
    }

    internal class Builder
    {
        private static int? _lastRunId = null;

        private static bool TryRun(int id)
        {
            if (ProblemsIndex.Map.TryGetValue(id, out var run))
            {
                try
                {
                    run();
                    _lastRunId = id;
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"실행 중 예외: {ex.Message}");
                    return false;
                }
            }

            Console.WriteLine("등록되지 않은 문제입니다. list로 확인하세요.");
            return false;
        }

        private static bool HandleCommand(string cmd)
        {
            if (cmd.Equals("exit", StringComparison.OrdinalIgnoreCase)) return false;
            if (cmd.Equals("list", StringComparison.OrdinalIgnoreCase)) { ProblemsIndex.PrintList(); return true; }
            if (cmd.Equals("help", StringComparison.OrdinalIgnoreCase)) { ConsoleUi.PrintHelp(); return true; }
            if (cmd.Equals("clear", StringComparison.OrdinalIgnoreCase)) { Console.Clear(); return true; }
            if (cmd.Equals("repeat", StringComparison.OrdinalIgnoreCase))
            {
                if (_lastRunId is int last) TryRun(last);
                else Console.WriteLine("재실행할 최근 문제가 없습니다.");
                return true;
            }

            Console.WriteLine("알 수 없는 명령입니다. help를 입력하세요.");
            return true;
        }

        public static void Main(string[] args)
        {
            ConsoleUi.PrintHelp();
            for (; ; )
            {
                Console.Write(ConsoleUi.Prompt);
                var s = Console.ReadLine();
                if (s is null) break;

                s = s.Trim();
                if (s.Length == 0) continue;

                if (!char.IsDigit(s[0]))
                {
                    if (!HandleCommand(s)) break;
                    continue;
                }

                if (int.TryParse(s, out var id))
                {
                    TryRun(id);
                }
                else
                {
                    Console.WriteLine("정수가 아닙니다. 다시 입력하세요.");
                }
            }
        }
    }
}
