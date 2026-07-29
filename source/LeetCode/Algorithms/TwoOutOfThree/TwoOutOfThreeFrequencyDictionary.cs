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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.TwoOutOfThree;

/// <inheritdoc />
public sealed class TwoOutOfThreeFrequencyDictionary : ITwoOutOfThree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var numToMaskDictionary = new Dictionary<int, int>();

        AddPresence(nums1, 1, numToMaskDictionary);
        AddPresence(nums2, 2, numToMaskDictionary);
        AddPresence(nums3, 4, numToMaskDictionary);

        var result = new List<int>();

        foreach (var pair in numToMaskDictionary)
        {
            if ((pair.Value & (pair.Value - 1)) != 0)
            {
                result.Add(pair.Key);
            }
        }

        return result;
    }

    private static void AddPresence(int[] nums, int arrayBit, Dictionary<int, int> numToMaskDictionary)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            ref var mask = ref CollectionsMarshal.GetValueRefOrAddDefault(numToMaskDictionary, num, out _);

            mask |= arrayBit;
        }
    }
}