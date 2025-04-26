// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LongestSquareStreakInAnArray;

/// <inheritdoc />
public class LongestSquareStreakInAnArrayHashSet : ILongestSquareStreakInAnArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int LongestSquareStreak(int[] nums)
    {
        var longestSquareStreak = -1;

        var numsHashSet = new HashSet<int>(nums);

        foreach (var num in nums)
        {
            var currentLongestSquareStreak = 1;

            long square = num;

            while (square * square <= int.MaxValue && numsHashSet.Contains((int)(square * square)))
            {
                currentLongestSquareStreak++;

                square = square * square;
            }

            if (currentLongestSquareStreak > 1)
            {
                longestSquareStreak = Math.Max(longestSquareStreak, currentLongestSquareStreak);
            }
        }

        return longestSquareStreak;
    }
}