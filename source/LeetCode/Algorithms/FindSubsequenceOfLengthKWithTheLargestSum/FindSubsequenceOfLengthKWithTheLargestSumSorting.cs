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

namespace LeetCode.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;

/// <inheritdoc />
public class FindSubsequenceOfLengthKWithTheLargestSumSorting : IFindSubsequenceOfLengthKWithTheLargestSum
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] MaxSubsequence(int[] nums, int k)
    {
        var indexedNums = new (int Index, int Value)[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            indexedNums[i] = (i, nums[i]);
        }

        Array.Sort(indexedNums, (a, b) => b.Value.CompareTo(a.Value));

        var kIndexedNums = new (int Index, int Value)[k];

        for (var i = 0; i < k; i++)
        {
            kIndexedNums[i] = indexedNums[i];
        }

        Array.Sort(kIndexedNums, (a, b) => a.Index.CompareTo(b.Index));

        var result = new int[k];

        for (var i = 0; i < k; i++)
        {
            result[i] = kIndexedNums[i].Value;
        }

        return result;
    }
}