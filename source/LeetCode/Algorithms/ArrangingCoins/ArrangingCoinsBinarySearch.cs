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

namespace LeetCode.Algorithms.ArrangingCoins;

/// <inheritdoc />
public class ArrangingCoinsBinarySearch : IArrangingCoins
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ArrangeCoins(int n)
    {
        long left = 0;
        long right = n;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);
            var curr = mid * (mid + 1) / 2;

            if (curr == n)
            {
                return (int)mid;
            }

            if (curr < n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)right;
    }
}