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

namespace LeetCode.Algorithms.TrionicArray1;

/// <inheritdoc />
public sealed class TrionicArray1Iterative : ITrionicArray1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool IsTrionic(int[] nums)
    {
        var n = nums.Length;

        if (n < 4)
        {
            return false;
        }

        var i = 1;

        while (i < n && nums[i - 1] < nums[i])
        {
            i++;
        }

        if (i < 2)
        {
            return false;
        }

        if (i == n)
        {
            return false;
        }

        var p = i;

        while (p < n && nums[p - 1] > nums[p])
        {
            p++;
        }

        if (p == i)
        {
            return false;
        }

        if (p == n)
        {
            return false;
        }

        var q = p;

        while (q < n && nums[q - 1] < nums[q])
        {
            q++;
        }

        return q == n && q > p;
    }
}