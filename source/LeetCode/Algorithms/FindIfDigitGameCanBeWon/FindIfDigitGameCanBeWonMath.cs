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

namespace LeetCode.Algorithms.FindIfDigitGameCanBeWon;

/// <inheritdoc />
public sealed class FindIfDigitGameCanBeWonMath : IFindIfDigitGameCanBeWon
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanAliceWin(int[] nums)
    {
        var n = nums.Length;

        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num < 10)
            {
                sum += num;
            }
            else
            {
                sum -= num;
            }
        }

        return sum != 0;
    }
}