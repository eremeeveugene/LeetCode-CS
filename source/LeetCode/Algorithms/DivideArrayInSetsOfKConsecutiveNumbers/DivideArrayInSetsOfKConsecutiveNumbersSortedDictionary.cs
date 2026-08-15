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

namespace LeetCode.Algorithms.DivideArrayInSetsOfKConsecutiveNumbers;

/// <inheritdoc />
public sealed class DivideArrayInSetsOfKConsecutiveNumbersSortedDictionary : IDivideArrayInSetsOfKConsecutiveNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n), where n is the length of the input array nums, due to the sorted dictionary
    ///     insertions and lookups
    ///     Space complexity - O(n), where n is the length of the input array nums
    /// </remarks>
    public bool IsPossibleDivide(int[] nums, int k)
    {
        if (nums.Length % k != 0)
        {
            return false;
        }

        var numsDictionary = new SortedDictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!numsDictionary.TryAdd(num, 1))
            {
                numsDictionary[num]++;
            }
        }

        while (numsDictionary.Count > 0)
        {
            var firstNum = numsDictionary.First().Key;

            if (!TryRemoveGroup(numsDictionary, firstNum, k))
            {
                return false;
            }
        }

        return true;
    }

    private static bool TryRemoveGroup(SortedDictionary<int, int> numsDictionary, int firstNum, int k)
    {
        for (var i = 0; i < k; i++)
        {
            var currentNum = firstNum + i;

            if (!numsDictionary.TryGetValue(currentNum, out var value))
            {
                return false;
            }

            if (value == 1)
            {
                numsDictionary.Remove(currentNum);
            }
            else
            {
                numsDictionary[currentNum] = value - 1;
            }
        }

        return true;
    }
}