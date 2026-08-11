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

namespace LeetCode.Algorithms.SmallestMissingIntegerGreaterThanSequentialPrefixSum;

/// <inheritdoc />
public sealed class SmallestMissingIntegerGreaterThanSequentialPrefixSumHashSet : ISmallestMissingIntegerGreaterThanSequentialPrefixSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of nums
    ///     Space complexity - O(n), where n is the length of nums
    /// </remarks>
    public int MissingInteger(int[] nums)
    {
        var n = nums.Length;

        var prefixSum = nums[0];

        var i = 1;

        while (i < n)
        {
            var num = nums[i];
            var previousNum = nums[i - 1];

            if (num - previousNum != 1)
            {
                break;
            }

            prefixSum += num;

            i++;
        }

        var numsHashSet = new HashSet<int>(nums);

        var missingInteger = prefixSum;

        while (numsHashSet.Contains(missingInteger))
        {
            missingInteger++;
        }

        return missingInteger;
    }
}