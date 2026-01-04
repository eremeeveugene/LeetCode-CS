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

namespace LeetCode.Algorithms.CountSymmetricIntegers;

/// <inheritdoc />
public class CountSymmetricIntegersIterative : ICountSymmetricIntegers
{
    /// <summary>
    ///     Time complexity - O(N log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public int CountSymmetricIntegers(int low, int high)
    {
        var count = 0;

        for (var i = low; i <= high; i++)
        {
            var numString = i.ToString();
            var length = numString.Length;

            if (length % 2 != 0)
            {
                continue;
            }

            var n = length / 2;
            int sumLeft = 0, sumRight = 0;

            for (var j = 0; j < n; j++)
            {
                sumLeft += numString[j] - '0';
                sumRight += numString[j + n] - '0';
            }

            if (sumLeft == sumRight)
            {
                count++;
            }
        }

        return count;
    }
}