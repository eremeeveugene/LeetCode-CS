// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.LargestPositiveIntegerThatExistsWithItsNegative;

/// <inheritdoc />
public class LargestPositiveIntegerThatExistsWithItsNegativeHashSet : ILargestPositiveIntegerThatExistsWithItsNegative
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMaxK(int[] nums)
    {
        var maxK = -1;

        var numsHashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (numsHashSet.Contains(-num))
            {
                maxK = Math.Max(maxK, Math.Abs(num));
            }
            else
            {
                numsHashSet.Add(num);
            }
        }

        return maxK;
    }
}