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

namespace LeetCode.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

/// <inheritdoc />
public sealed class MakeTwoArraysEqualByReversingSubarraysDictionary : IMakeTwoArraysEqualByReversingSubarrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var targetDictionary = new Dictionary<int, int>();

        for (var i = 0; i < target.Length; i++)
        {
            var targetKey = target[i];

            if (!targetDictionary.TryAdd(targetKey, 1))
            {
                targetDictionary[targetKey]++;
            }
        }

        for (var i = 0; i < arr.Length; i++)
        {
            var arrKey = arr[i];

            if (targetDictionary.TryGetValue(arrKey, out var targetValue))
            {
                if (targetValue == 0)
                {
                    return false;
                }

                targetDictionary[arrKey] = targetValue - 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}