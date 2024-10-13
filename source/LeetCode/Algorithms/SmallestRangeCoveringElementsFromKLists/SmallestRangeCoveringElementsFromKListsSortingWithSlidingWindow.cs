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

namespace LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;

/// <inheritdoc />
public class SmallestRangeCoveringElementsFromKListsSortingWithSlidingWindow : ISmallestRangeCoveringElementsFromKLists
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        var mergedNums = new List<(int Value, int ListIndex)>();

        for (var i = 0; i < nums.Count; i++)
        {
            mergedNums.AddRange(nums[i].Select(num => (num, i)));
        }

        var sortedNums = mergedNums.OrderBy(x => x.Value).ToArray();

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
}