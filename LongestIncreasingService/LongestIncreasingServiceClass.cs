using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingService
{
    public class LongestIncreasingServiceClass : ILongestIncreasingService
    {
        public IReadOnlyList<int> GetLongestIncreasingSubsequence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return Array.Empty<int>();

            var numbers = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 0)
                return Array.Empty<int>();

            int n = numbers.Length;
            int[] dp = new int[n];
            int[] previous = new int[n];

            Array.Fill(dp, 1);
            Array.Fill(previous, -1);

            int maxLength = 1;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        previous[i] = j;
                    }
                }

                // ensures earliest if tie
                if (dp[i] > maxLength)
                {
                    maxLength = dp[i];
                    maxIndex = i;
                }
            }

            return BuildSequence(numbers, previous, maxIndex);
        }

        private static IReadOnlyList<int> BuildSequence(int[] numbers, int[] previous, int index)
        {
            var stack = new Stack<int>();

            while (index >= 0)
            {
                stack.Push(numbers[index]);
                index = previous[index];
            }

            return stack.ToList();
        }
    }
}
