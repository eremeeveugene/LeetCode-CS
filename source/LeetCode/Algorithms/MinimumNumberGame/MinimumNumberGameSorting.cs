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

namespace LeetCode.Algorithms.MinimumNumberGame;

/// <inheritdoc />
public class MinimumNumberGameSorting : IMinimumNumberGame
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i += 2)
        {
            result[i] = nums[i + 1];
            result[i + 1] = nums[i];
        }

        return result;
    }
}