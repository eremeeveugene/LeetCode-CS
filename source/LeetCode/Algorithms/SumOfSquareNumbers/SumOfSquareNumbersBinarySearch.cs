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

namespace LeetCode.Algorithms.SumOfSquareNumbers;

/// <inheritdoc />
public class SumOfSquareNumbersBinarySearch : ISumOfSquareNumbers
{
    /// <summary>
    ///     Time complexity - O(Sqrt(c) * log c)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public bool JudgeSquareSum(int c)
    {
        for (long a = 0; a * a <= c; a++)
        {
            var b = c - (int)(a * a);

            if (BinarySearch(0, b, b))
            {
                return true;
            }
        }

        return false;
    }

    private static bool BinarySearch(long s, long e, int n)
    {
        while (true)
        {
            if (s > e)
            {
                return false;
            }

            var mid = s + ((e - s) / 2);

            if (mid * mid == n)
            {
                return true;
            }

            if (mid * mid > n)
            {
                e = mid - 1;

                continue;
            }

            s = mid + 1;
        }
    }
}