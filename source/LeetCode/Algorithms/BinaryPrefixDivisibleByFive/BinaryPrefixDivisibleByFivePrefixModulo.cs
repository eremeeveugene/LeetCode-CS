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

namespace LeetCode.Algorithms.BinaryPrefixDivisibleByFive;

/// <inheritdoc />
public sealed class BinaryPrefixDivisibleByFivePrefixModulo : IBinaryPrefixDivisibleByFive
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        var result = new bool[nums.Length];

        var prefix = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            prefix = ((prefix << 1) + nums[i]) % 5;

            result[i] = prefix == 0;
        }

        return result;
    }
}