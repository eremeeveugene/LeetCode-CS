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

namespace LeetCode.Algorithms.SumOfUniqueElements;

/// <inheritdoc />
public sealed class SumOfUniqueElementsFrequencyDictionary : ISumOfUniqueElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int SumOfUnique(int[] nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!frequencyDictionary.TryAdd(num, 1))
            {
                frequencyDictionary[num]++;
            }
        }

        var uniqueNums = new int[frequencyDictionary.Count];

        frequencyDictionary.Keys.CopyTo(uniqueNums, 0);

        var sum = 0;

        for (var i = 0; i < uniqueNums.Length; i++)
        {
            var num = uniqueNums[i];

            if (frequencyDictionary[num] == 1)
            {
                sum += num;
            }
        }

        return sum;
    }
}