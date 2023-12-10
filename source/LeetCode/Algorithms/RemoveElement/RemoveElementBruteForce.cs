// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.RemoveElement;

/// <summary>
///     https://leetcode.com/problems/remove-element/description/
/// </summary>
public static class RemoveElementBruteForce
{
    /// <summary>
    ///     Time complexity - O (n^3)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums, int val)
    {
        for (var k = 0; k < nums.Length; k++)
            for (var i = 0; i < nums.Length; i++)
                if (nums[i] == val)
                    for (var j = i; j < nums.Length - 1; j++)
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);

        return nums.Count(num => !num.Equals(val));
    }
}