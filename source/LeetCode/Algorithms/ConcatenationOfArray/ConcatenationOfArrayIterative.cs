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

namespace LeetCode.Algorithms.ConcatenationOfArray;

public class ConcatenationOfArrayIterative : IConcatenationOfArray
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[nums.Length + i] = nums[i];
        }

        return result;
    }
}