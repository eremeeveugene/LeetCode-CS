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

namespace LeetCode.Algorithms.SpecialArray2;

/// <inheritdoc />
public sealed class SpecialArray2BruteForce : ISpecialArray2
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        var result = new bool[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            result[i] = IsArraySpecial(nums, queries[i][0], queries[i][1]);
        }

        return result;
    }

    private static bool IsArraySpecial(int[] nums, int start, int end)
    {
        for (var i = start; i < end; i++)
        {
            if (nums[i] % 2 == nums[i + 1] % 2)
            {
                return false;
            }
        }

        return true;
    }
}