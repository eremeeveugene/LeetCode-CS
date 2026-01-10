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

namespace LeetCode.Algorithms.TwoOutOfThree;

/// <inheritdoc />
public sealed class TwoOutOfThreeFrequencyDictionary : ITwoOutOfThree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <param name="nums3"></param>
    /// <returns></returns>
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var frequencyDictionary = new Dictionary<int, int>();

        foreach (var num1 in new HashSet<int>(nums1).Where(num1 => !frequencyDictionary.TryAdd(num1, 1)))
        {
            frequencyDictionary[num1]++;
        }

        foreach (var num2 in new HashSet<int>(nums2).Where(num2 => !frequencyDictionary.TryAdd(num2, 1)))
        {
            frequencyDictionary[num2]++;
        }

        foreach (var num3 in new HashSet<int>(nums3).Where(num3 => !frequencyDictionary.TryAdd(num3, 1)))
        {
            frequencyDictionary[num3]++;
        }

        var result = new List<int>();

        foreach (var frequency in frequencyDictionary)
        {
            if (frequency.Value < 2)
            {
                continue;
            }

            result.Add(frequency.Key);
        }

        return result;
    }
}