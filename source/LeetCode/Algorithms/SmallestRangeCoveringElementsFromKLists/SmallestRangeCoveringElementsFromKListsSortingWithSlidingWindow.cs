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

namespace LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;

/// <inheritdoc />
public sealed class SmallestRangeCoveringElementsFromKListsSortingWithSlidingWindow : ISmallestRangeCoveringElementsFromKLists
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        var sortedNums = BuildSortedNums(nums);

        var countMap = new Dictionary<int, int>();
        var min = 0;
        var max = 0;
        var start = 0;
        var matchedLists = 0;
        var diff = int.MaxValue;

        for (var end = 0; end < sortedNums.Length; end++)
        {
            countMap.TryAdd(sortedNums[end].ListIndex, 0);

            countMap[sortedNums[end].ListIndex]++;

            if (countMap[sortedNums[end].ListIndex] == 1)
            {
                matchedLists++;
            }

            while (matchedLists == nums.Count)
            {
                var currentMin = sortedNums[start].Value;
                var currentMax = sortedNums[end].Value;
                var currentDiff = currentMax - currentMin;

                if (currentDiff < diff)
                {
                    min = currentMin;
                    max = currentMax;
                    diff = currentDiff;
                }

                countMap[sortedNums[start].ListIndex]--;

                if (countMap[sortedNums[start].ListIndex] == 0)
                {
                    matchedLists--;
                }

                start++;
            }
        }

        return [min, max];
    }

    private static (int Value, int ListIndex)[] BuildSortedNums(IList<IList<int>> nums)
    {
        var totalCount = 0;

        for (var i = 0; i < nums.Count; i++)
        {
            totalCount += nums[i].Count;
        }

        var sortedNums = new (int Value, int ListIndex)[totalCount];
        var sortedIndex = 0;

        for (var i = 0; i < nums.Count; i++)
        {
            var list = nums[i];

            for (var j = 0; j < list.Count; j++)
            {
                var num = list[j];

                sortedNums[sortedIndex] = (num, i);

                sortedIndex++;
            }
        }

        Array.Sort(
            sortedNums,
            (first, second) =>
            {
                var valueComparison = first.Value.CompareTo(second.Value);

                return valueComparison != 0 ? valueComparison : first.ListIndex.CompareTo(second.ListIndex);
            });

        return sortedNums;
    }
}