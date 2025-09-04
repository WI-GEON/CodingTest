using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Problems
{
    internal class Builder
    {
        static void Main(string[] args)
        {
            int? _testID = null;
            while (true)
            {
                if (_testID == null)
                {
                    Console.Write("풀고 싶은 문제 번호를 입력하세요 (종료: exit) : ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int testID))
                    {
                        _testID = testID;
                    }
                    else if (input.ToLower() == "exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                        _testID = null;
                    }
                }
                else
                {
                    switch (_testID)
                    {
                        default:
                            Console.WriteLine("아직 풀지 못한 문제입니다. 다시 입력해주세요.");
                            break;
                        case 1008:
                            Problems.SolvedAc.Problem1008.Run();
                            break;
                        case 10869:
                            Problems.SolvedAc.Problem10869.Run();
                            break;
                        case 10926:
                            Problems.SolvedAc.Problem10926.Run();
                            break;
                        case 18108:
                            Problems.SolvedAc.Problem18108.Run();
                            break;
                        case 10430:
                            Problems.SolvedAc.Problem10430.Run();
                            break;
                        case 2588:
                            Problems.SolvedAc.Problem2588.Run();
                            break;
                        case 11382:
                            Problems.SolvedAc.Problem11382.Run();
                            break;
                        case 1330:
                            Problems.SolvedAc.Problem1330.Run();
                            break;
                        case 9498:
                            Problems.SolvedAc.Problem9498.Run();
                            break;
                        case 2753:
                            Problems.SolvedAc.Problem2753.Run();
                            break;
                        case 14681:
                            Problems.SolvedAc.Problem14681.Run();
                            break;
                        case 2884:
                            Problems.SolvedAc.Problem2884.Run();
                            break;
                        case 2525:
                            Problems.SolvedAc.Problem2525.Run();
                            break;
                        case 2480:
                            Problems.SolvedAc.Problem2480.Run();
                            break;
                        case 2739:
                            Problems.SolvedAc.Problem2739.Run();
                            break;
                        case 10950:
                            Problems.SolvedAc.Problem10950.Run();
                            break;
                        case 8393:
                            Problems.SolvedAc.Problem8393.Run();
                            break;

                    }

                    _testID = null;
                }
            }

        }
    }
}
