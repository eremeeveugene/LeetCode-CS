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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <inheritdoc />
public sealed class ThirdMaximumNumberLinear : IThirdMaximumNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ThirdMax(int[] nums)
    {
        var firstMax = long.MinValue;
        var secondMax = long.MinValue;
        var thirdMax = long.MinValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num < firstMax && num > secondMax)
            {
                thirdMax = secondMax;
                secondMax = num;
            }
            else if (num < secondMax)
            {
                thirdMax = Math.Max(thirdMax, num);
            }
        }

        return (int)(thirdMax == long.MinValue ? firstMax : thirdMax);
    }
}