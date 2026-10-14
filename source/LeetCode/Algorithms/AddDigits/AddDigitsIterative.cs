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

namespace LeetCode.Algorithms.AddDigits;

/// <inheritdoc />
public sealed class AddDigitsIterative : IAddDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(n))
    ///     Space complexity - O(1)
    /// </remarks>
    public int AddDigits(int num)
    {
        while (num > 9)
        {
            var sum = 0;

            while (num > 0)
            {
                sum += num % 10;

                num /= 10;
            }

            num = sum;
        }

        return num;
    }
}