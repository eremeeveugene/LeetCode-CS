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

namespace LeetCode.Algorithms.ShuffleTheArray;

/// <inheritdoc />
public class ShuffleTheArrayIterative : IShuffleTheArray
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[n * 2];

        for (var i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            result[(i * 2) + 1] = nums[i + n];
        }

        return result;
    }
}