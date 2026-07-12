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

namespace LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;

/// <inheritdoc />
public sealed class MinimumOperationsToConvertAllElementsToZeroStackAsList : IMinimumOperationsToConvertAllElementsToZero
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinOperations(int[] nums)
    {
        var numsList = new List<int>(nums.Length);

        var minOperations = 0;

        foreach (var num in nums)
        {
            while (numsList.Count > 0 && numsList[^1] > num)
            {
                numsList.RemoveAt(numsList.Count - 1);
            }

            if (num == 0)
            {
                continue;
            }

            if (numsList.Count > 0 && numsList[^1] >= num)
            {
                continue;
            }

            numsList.Add(num);

            minOperations++;
        }

        return minOperations;
    }
}