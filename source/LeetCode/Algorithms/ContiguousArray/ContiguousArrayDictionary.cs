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

namespace LeetCode.Algorithms.ContiguousArray;

/// <inheritdoc />
public class ContiguousArrayDictionary : IContiguousArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMaxLength(int[] nums)
    {
        var maxLength = 0;
        var count = 0;
        var dictionary = new Dictionary<int, int> { { 0, -1 } };

        for (var i = 0; i < nums.Length; i++)
        {
            count += nums[i] == 1 ? 1 : -1;

            if (!dictionary.TryAdd(count, i))
            {
                maxLength = Math.Max(maxLength, i - dictionary[count]);
            }
        }

        return maxLength;
    }
}