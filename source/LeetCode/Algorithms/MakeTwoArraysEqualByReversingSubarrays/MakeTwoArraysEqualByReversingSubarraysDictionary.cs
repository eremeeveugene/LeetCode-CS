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

namespace LeetCode.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

/// <inheritdoc />
public class MakeTwoArraysEqualByReversingSubarraysDictionary : IMakeTwoArraysEqualByReversingSubarrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="target"></param>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var targetDictionary = new Dictionary<int, int>();

        foreach (var targetKey in target)
        {
            if (!targetDictionary.TryAdd(targetKey, 1))
            {
                targetDictionary[targetKey]++;
            }
        }

        foreach (var arrKey in arr)
        {
            if (targetDictionary.TryGetValue(arrKey, out var targetValue))
            {
                if (targetValue == 0)
                {
                    return false;
                }

                targetDictionary[arrKey] = --targetValue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}