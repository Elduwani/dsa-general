namespace DotnetDSA.Entities;

public class CountPaths
{
    //https://www.structy.net/problems/count-paths
    private static int Evaluate(char[,] grid, Dictionary<string, int> memo, int x = 0, int y = 0)
    {
        string key = $"{x}-{y}";

        if (memo.TryGetValue(key, out int value))
        {
            return value;
        }

        if (x >= grid.GetLength(1) || y >= grid.GetLength(0))
        {
            //Out of bounds...
            return 0;
        }
        //Comes after to avoid IndexOutOfRangeException
        if (grid[y, x] == 'X')
        {
            //Hit a wall...
            return 0;
        }
        if (x == grid.GetLength(1) - 1 && y == grid.GetLength(0) - 1)
        {
            //Reached the last spot in the grid
            return 1;
        }

        int result = Evaluate(grid, memo, x + 1, y) + Evaluate(grid, memo, x, y + 1);
        memo.Add(key, result);
        return result;
    }

    public void Run()
    {
        var testCases = new List<char[,]>
        {
            new char[2, 2]
        {
            {'O', 'O'},
            {'O', 'O'},
        },
            new char[3, 3]
        {
            {'O', 'O', 'X'},
            {'O', 'O', 'O'},
            {'O', 'O', 'O'},
        },
            new char[3, 3]
        {
            {'O', 'O', 'O'},
            {'O', 'O', 'X'},
            {'O', 'O', 'O'},
        },
            new char[3, 3]
        {
            {'O', 'O', 'O'},
            {'O', 'X', 'X'},
            {'O', 'O', 'O'},
        },
            new char[5, 6]
        {
            {'O', 'O', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'X', 'O', 'O', 'O'},
            {'X', 'O', 'X', 'O', 'O', 'O'},
            {'X', 'X', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O'},
        },
            new char[5, 6]
        {
            {'O', 'O', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'X'},
            {'X', 'O', 'O', 'O', 'O', 'O'},
            {'X', 'X', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O'},
        },
            new char[5, 6]
        {
            {'O', 'O', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'X'},
            {'X', 'O', 'O', 'O', 'O', 'O'},
            {'X', 'X', 'X', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'X'},
        },
            new char[15, 15]
        {
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
        },
        };

        Console.WriteLine($"\n>> Running {GetType().Name} recursive function <<");
        foreach (var testCase in testCases)
        {
            var memo = new Dictionary<string, int>();
            Console.WriteLine($"X: {testCase.GetLength(1)}, Y: {testCase.GetLength(0)} > {Evaluate(testCase, memo)}");
        }
    }
}
