﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheMiddleIndexInArray;

/// <inheritdoc />
public class FindTheMiddleIndexInArrayIterative : IFindTheMiddleIndexInArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMiddleIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}