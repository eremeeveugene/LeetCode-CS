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

namespace LeetCode.Algorithms.SetMismatch;

/// <inheritdoc />
public sealed class SetMismatchCounting : ISetMismatch
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] FindErrorNums(int[] nums)
    {
        var duplicate = 0;
        var missing = 0;

        var count = new int[nums.Length + 1];

        foreach (var num in nums)
        {
            count[num]++;
        }

        for (var i = 1; i < count.Length; i++)
        {
            switch (count[i])
            {
                case 0:
                    missing = i;
                    break;
                case 2:
                    duplicate = i;
                    break;
            }

            if (duplicate > 0 && missing > 0)
            {
                break;
            }
        }

        return [duplicate, missing];
    }
}