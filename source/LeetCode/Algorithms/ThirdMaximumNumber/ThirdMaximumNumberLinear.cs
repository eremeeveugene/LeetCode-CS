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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <inheritdoc />
public class ThirdMaximumNumberLinear : IThirdMaximumNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int ThirdMax(int[] nums)
    {
        switch (nums.Length)
        {
            case 1:
                return nums[0];
            case 2:
                return Math.Max(nums[0], nums[1]);
        }

        int? firstMax = null, secondMax = null, thirdMax = null;

        foreach (var num in nums)
        {
            if (num == firstMax || num == secondMax || num == thirdMax)
            {
                continue;
            }

            if (!firstMax.HasValue || num > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if (!secondMax.HasValue || num > secondMax)
            {
                thirdMax = secondMax;
                secondMax = num;
            }
            else if (!thirdMax.HasValue || num > thirdMax)
            {
                thirdMax = num;
            }
        }

        return thirdMax ?? firstMax.GetValueOrDefault();
    }
}