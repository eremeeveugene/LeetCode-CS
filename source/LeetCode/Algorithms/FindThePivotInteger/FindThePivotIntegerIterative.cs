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

namespace LeetCode.Algorithms.FindThePivotInteger;

/// <inheritdoc />
public class FindThePivotIntegerIterative : IFindThePivotInteger
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int PivotInteger(int n)
    {
        var left = 1;
        var right = n;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);
            var leftSum = Sum(1, mid);
            var rightSum = Sum(mid, n);

            if (leftSum == rightSum)
            {
                return mid;
            }

            if (leftSum < rightSum)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    private static int Sum(int left, int right)
    {
        var sum = 0;

        for (var i = left; i <= right; i++)
        {
            sum += i;
        }

        return sum;
    }
}