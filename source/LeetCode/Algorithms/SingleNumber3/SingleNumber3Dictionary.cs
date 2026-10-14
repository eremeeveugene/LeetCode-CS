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

namespace LeetCode.Algorithms.SingleNumber3;

/// <inheritdoc />
public sealed class SingleNumber3Dictionary : ISingleNumber3
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] SingleNumber(int[] nums)
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

        var keys = new int[numsDictionary.Count];

        numsDictionary.Keys.CopyTo(keys, 0);

        var result = new int[2];
        var resultIndex = 0;

        for (var i = 0; i < keys.Length; i++)
        {
            var key = keys[i];

            if (numsDictionary[key] < 2)
            {
                result[resultIndex] = key;

                resultIndex++;
            }
        }

        return result;
    }
}