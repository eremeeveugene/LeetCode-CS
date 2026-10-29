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
public sealed class SortTheJumbledNumbersSortingDictionary : SortTheJumbledNumbersBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public override int[] SortJumbled(int[] mapping, int[] nums)
    {
        var mappedNumToNumsDictionary = new Dictionary<int, List<int>>();

        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var mappedNum = GetMappedNum(mapping, num);

            if (!mappedNumToNumsDictionary.TryGetValue(mappedNum, out var groupNums))
            {
                groupNums = [];

                mappedNumToNumsDictionary[mappedNum] = groupNums;
            }

            groupNums.Add(num);
        }

        var sortedMappedNums = new int[mappedNumToNumsDictionary.Count];

        mappedNumToNumsDictionary.Keys.CopyTo(sortedMappedNums, 0);

        Array.Sort(sortedMappedNums);

        var resultIndex = 0;

        for (var i = 0; i < sortedMappedNums.Length; i++)
        {
            var mappedNum = sortedMappedNums[i];
            var groupNums = mappedNumToNumsDictionary[mappedNum];

            for (var j = 0; j < groupNums.Count; j++)
            {
                nums[resultIndex] = groupNums[j];

                resultIndex++;
            }
        }

        return nums;
    }
}