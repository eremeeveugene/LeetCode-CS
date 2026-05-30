// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

/// <inheritdoc />
public sealed class MaximumCountOfPositiveIntegerAndNegativeIntegerBruteForce : IMaximumCountOfPositiveIntegerAndNegativeInteger
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaximumCount(int[] nums)
    {
        var negativeCount = 0;
        var positiveCount = 0;

        foreach (var num in nums)
        {
            switch (num)
            {
                case < 0:
                    negativeCount++;
                    break;
                case > 0:
                    positiveCount++;
                    break;
            }
        }

        return Math.Max(negativeCount, positiveCount);
    }
}