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

        foreach (var num in nums)
        {
            if (!frequencyDictionary.TryAdd(num, 1))
            {
                frequencyDictionary[num]++;
            }
        }

        return frequencyDictionary.Where(frequency => frequency.Value == 1).Sum(numsKeyValuePair => numsKeyValuePair.Key);
    }
}