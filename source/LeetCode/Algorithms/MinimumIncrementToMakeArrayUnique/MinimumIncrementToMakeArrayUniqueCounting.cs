﻿namespace LeetCode.Algorithms.MinimumIncrementToMakeArrayUnique;

/// <inheritdoc />
public class MinimumIncrementToMakeArrayUniqueCounting : IMinimumIncrementToMakeArrayUnique
{
    /// <summary>
    ///     Time complexity - O(n + k)
    ///     Space complexity - O(n + k)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinIncrementForUnique(int[] nums)
    {
        var result = 0;

        var frequency = new int[nums.Length + nums.Max()];

        foreach (var num in nums)
        {
            frequency[num]++;
        }

        for (var i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] <= 1)
            {
                continue;
            }

            var duplicates = frequency[i] - 1;

            frequency[i + 1] += duplicates;

            frequency[i] = 1;

            result += duplicates;
        }

        return result;
    }
}