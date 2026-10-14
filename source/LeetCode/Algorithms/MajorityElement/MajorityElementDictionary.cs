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

namespace LeetCode.Algorithms.MajorityElement;

/// <inheritdoc />
public sealed class MajorityElementDictionary : IMajorityElement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MajorityElement(int[] nums)
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

        var result = 0;
        var maxFrequency = 0;

        var keys = new int[frequencyDictionary.Count];
        var values = new int[frequencyDictionary.Count];

        frequencyDictionary.Keys.CopyTo(keys, 0);
        frequencyDictionary.Values.CopyTo(values, 0);

        for (var i = 0; i < keys.Length; i++)
        {
            var key = keys[i];
            var value = values[i];

            if (value <= maxFrequency)
            {
                continue;
            }

            maxFrequency = value;
            result = key;
        }

        return result;
    }
}