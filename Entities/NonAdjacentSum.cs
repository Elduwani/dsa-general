using System;

namespace DotnetDSA;

public class NonAdjacentSum
{
    private static int Evaluate(List<int> numbers, Dictionary<int, int> memo, int index = 0)
    {
        if (memo.ContainsKey(index))
        {
            return memo[index];
        }
        if (index >= numbers.Count)
        {
            return 0;
        }

        int including = numbers[index] + Evaluate(numbers, memo, index + 2);
        int excluding = Evaluate(numbers, memo, index + 1);
        memo.Add(index, Math.Max(including, excluding));
        return memo[index];
    }

    public void Run()
    {
        var testCases = new List<List<int>>
        {
            ([2, 4, 5, 12, 7]),             //16
            ([7, 5, 5, 12]),            //19
            ([7, 5, 5, 12, 17, 29]),    //48
            ([
                72, 62, 10,  6, 20, 19, 42,
                46, 24, 78, 30, 41, 75, 38,
                23, 28, 66, 55, 12, 17, 9,
                12, 3, 1, 19, 30, 50, 20
            ]),                         //488
            ([
                72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
                30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
                83, 80, 56, 68,  6, 22, 56, 96, 77, 98,
                61, 20,  0, 76, 53, 74,  8, 22, 92, 37,
                30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
                72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
                42
            ])                          //1465
        };

        Console.WriteLine($"\n>> Running {GetType().Name} recursive function <<");
        foreach (var testCase in testCases)
        {
            var memo = new Dictionary<int, int>();
            Console.WriteLine($">> {Evaluate(testCase, memo)}");
        }
    }
}
