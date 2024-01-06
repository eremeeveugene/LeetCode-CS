// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.Sqrt;

/// <summary>
///     https://leetcode.com/problems/sqrtx/description/
/// </summary>
public static class SqrtBinarySearch
{
    /// <summary>
    ///     Time complexity -  O (log n)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int GetResult(int x)
    {
        if (x is 0 or 1)
        {
            return x;
        }

        var start = 1;
        var end = x;
        var ans = 0;

        while (start <= end)
        {
            var mid = start + ((end - start) / 2);

            if (mid <= x / mid)
            {
                start = mid + 1;

                ans = mid;
            }
            else
            {
                end = mid - 1;
            }
        }

        return ans;
    }
}