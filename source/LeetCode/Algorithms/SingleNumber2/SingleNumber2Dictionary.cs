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

namespace LeetCode.Algorithms.SingleNumber2;

/// <inheritdoc />
public sealed class SingleNumber2Dictionary : ISingleNumber2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int SingleNumber(int[] nums)
    {
        var numsDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!numsDictionary.TryAdd(num, 1))
            {
                numsDictionary[num]++;
            }
        }

        return numsDictionary.First(num => num.Value < 3).Key;
    }
}