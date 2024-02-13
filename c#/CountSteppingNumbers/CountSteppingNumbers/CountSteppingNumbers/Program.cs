using System;
using System.Collections.Generic;

public class Solution
{
    public int CountSteppingNumbers(string low, string high)
    {
        List<int> result = new List<int>();
        int lowNum = int.Parse(low);
        int highNum = int.Parse(high);

        void DFS(int num)
        {
            if (lowNum <= num && num <= highNum)
            {
                result.Add(num);
            }

            if (num == 0 || num > highNum)
            {
                return;
            }

            int lastDigit = num % 10;
            if (lastDigit > 0)
            {
                DFS(num * 10 + lastDigit - 1);
            }
            if (lastDigit < 9)
            {
                DFS(num * 10 + lastDigit + 1);
            }
        }

        for (int i = 0; i <= 9; i++)
        {
            DFS(i);
        }

        return result.Count;
    }

    public static void Main()
    {
        Solution solution = new Solution();

        // Example usage:
        string low1 = "1", high1 = "11";
        Console.WriteLine(solution.CountSteppingNumbers(low1, high1));  // Output: 10

        string low2 = "90", high2 = "101";
        Console.WriteLine(solution.CountSteppingNumbers(low2, high2));  // Output: 2
    }
}
