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

namespace LeetCode.Algorithms.ValidElementsInAnArray;

/// <inheritdoc />
public sealed class ValidElementsInAnArrayPrefixSum : IValidElementsInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> FindValidElements(int[] nums)
    {
        var n = nums.Length;

        Span<bool> valid = stackalloc bool[n];

        var leftMax = nums[0];

        valid[0] = true;

        for (var i = 1; i < n - 1; i++)
        {
            var num = nums[i];

            if (num <= leftMax)
            {
                continue;
            }

            valid[i] = true;

            leftMax = num;
        }

        var rightMax = nums[n - 1];

        valid[n - 1] = true;

        var validCount = n == 1 ? 1 : 2;

        for (var i = n - 2; i >= 1; i--)
        {
            var num = nums[i];

            if (num > rightMax)
            {
                valid[i] = true;

                rightMax = num;
            }

            if (valid[i])
            {
                validCount++;
            }
        }

        var result = new int[validCount];

        var resultIndex = 0;

        for (var i = 0; i < n; i++)
        {
            if (!valid[i])
            {
                continue;
            }

            result[resultIndex] = nums[i];

            resultIndex++;
        }

        return result;
    }
}