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

namespace LeetCode.Algorithms.MajorityElement;

/// <inheritdoc />
public class MajorityElementDictionary : IMajorityElement
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MajorityElement(int[] nums)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!frequencyDictionary.TryAdd(num, 1))
            {
                frequencyDictionary[num]++;
            }
        }

        var result = 0;
        var maxFrequency = 0;

        foreach (var frequency in frequencyDictionary.Where(pair => pair.Value > maxFrequency))
        {
            maxFrequency = frequency.Value;
            result = frequency.Key;
        }

        return result;
    }
}