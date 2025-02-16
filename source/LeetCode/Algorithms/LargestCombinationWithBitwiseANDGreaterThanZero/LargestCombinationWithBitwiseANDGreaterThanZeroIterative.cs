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

namespace LeetCode.Algorithms.LargestCombinationWithBitwiseANDGreaterThanZero;

/// <inheritdoc />
public class LargestCombinationWithBitwiseANDGreaterThanZeroIterative : ILargestCombinationWithBitwiseANDGreaterThanZero
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="candidates"></param>
    /// <returns></returns>
    public int LargestCombination(int[] candidates)
    {
        var maxCount = 0;

        for (var i = 0; i < 24; i++)
        {
            var count = candidates.Count(candidate => (candidate & (1 << i)) != 0);

            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}