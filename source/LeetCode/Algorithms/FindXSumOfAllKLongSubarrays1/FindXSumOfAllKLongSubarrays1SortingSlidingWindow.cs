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

namespace LeetCode.Algorithms.FindXSumOfAllKLongSubarrays1;

/// <inheritdoc />
public sealed class FindXSumOfAllKLongSubarrays1SortingSlidingWindow : IFindXSumOfAllKLongSubarrays1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * k log k), where n is the length of nums
    ///     Space complexity - O(k)
    /// </remarks>
    public int[] FindXSum(int[] nums, int k, int x)
    {
        var n = nums.Length;

        var result = new int[n - k + 1];

        var numToFrequencyDictionary = new Dictionary<int, int>();

        Span<int> distinctNums = stackalloc int[k];

        for (var i = 0; i < k; i++)
        {
            var num = nums[i];

            ref var count = ref CollectionsMarshal.GetValueRefOrAddDefault(numToFrequencyDictionary, num, out _);

            count++;
        }

        for (var start = 0; start < result.Length; start++)
        {
            if (start > 0)
            {
                var outgoingNum = nums[start - 1];

                numToFrequencyDictionary[outgoingNum]--;

                if (numToFrequencyDictionary[outgoingNum] == 0)
                {
                    numToFrequencyDictionary.Remove(outgoingNum);
                }

                var incomingNum = nums[start + k - 1];

                ref var incomingCount = ref CollectionsMarshal.GetValueRefOrAddDefault(numToFrequencyDictionary, incomingNum, out _);

                incomingCount++;
            }

            var distinctCount = numToFrequencyDictionary.Count;

            using var keyEnumerator = numToFrequencyDictionary.Keys.GetEnumerator();

            var keyIndex = 0;

            while (keyEnumerator.MoveNext())
            {
                distinctNums[keyIndex] = keyEnumerator.Current;

                keyIndex++;
            }

            distinctNums[..distinctCount]
                .Sort((first, second) =>
                {
                    var firstFrequency = numToFrequencyDictionary[first];
                    var secondFrequency = numToFrequencyDictionary[second];

                    if (firstFrequency != secondFrequency)
                    {
                        return secondFrequency - firstFrequency;
                    }

                    return second - first;
                });

            var take = Math.Min(x, distinctCount);

            var xSum = 0;

            for (var i = 0; i < take; i++)
            {
                var num = distinctNums[i];

                xSum += num * numToFrequencyDictionary[num];
            }

            result[start] = xSum;
        }

        return result;
    }
}