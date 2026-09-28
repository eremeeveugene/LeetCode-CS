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

namespace LeetCode.Algorithms.MinimumNumberOfIncrementsOnSubarraysToFormTargetArray;

/// <inheritdoc />
public sealed class MinimumNumberOfIncrementsOnSubarraysToFormTargetArrayGreedy : IMinimumNumberOfIncrementsOnSubarraysToFormTargetArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Existing increments can extend to the next position; only an increase requires additional operations.
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinNumberOperations(int[] target)
    {
        var n = target.Length;

        var previousValue = target[0];
        var result = previousValue;

        for (var i = 1; i < n; i++)
        {
            var currentValue = target[i];
            var additionalOperations = currentValue - previousValue;

            if (additionalOperations > 0)
            {
                result += additionalOperations;
            }

            previousValue = currentValue;
        }

        return result;
    }
}