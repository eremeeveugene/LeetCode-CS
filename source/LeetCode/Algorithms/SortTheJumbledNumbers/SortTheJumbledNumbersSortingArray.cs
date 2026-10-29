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

namespace LeetCode.Algorithms.SortTheJumbledNumbers;

/// <inheritdoc />
public sealed class SortTheJumbledNumbersSortingArray : SortTheJumbledNumbersBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public override int[] SortJumbled(int[] mapping, int[] nums)
    {
        var n = nums.Length;

        var mappedNums = new (int MappedNum, int Index)[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var mappedNum = GetMappedNum(mapping, num);

            mappedNums[i] = (mappedNum, i);
        }

        Array.Sort(mappedNums);

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var index = mappedNums[i].Index;

            result[i] = nums[index];
        }

        return result;
    }
}