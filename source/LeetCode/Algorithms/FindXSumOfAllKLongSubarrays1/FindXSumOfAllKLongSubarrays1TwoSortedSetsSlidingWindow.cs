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

namespace LeetCode.Algorithms.FindXSumOfAllKLongSubarrays1;

/// <inheritdoc />
public sealed class FindXSumOfAllKLongSubarrays1TwoSortedSetsSlidingWindow : IFindXSumOfAllKLongSubarrays1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log k), where n is the length of nums
    ///     Space complexity - O(k)
    /// </remarks>
    public int[] FindXSum(int[] nums, int k, int x)
    {
        var n = nums.Length;

        var result = new int[n - k + 1];

        var numToFrequencyDictionary = new Dictionary<int, int>();
        var numToIsInTopDictionary = new Dictionary<int, bool>();

        var top = new SortedSet<FrequencyValue>();
        var rest = new SortedSet<FrequencyValue>();

        var topSum = 0;

        for (var i = 0; i < k; i++)
        {
            AddNum(nums[i], numToFrequencyDictionary, numToIsInTopDictionary, top, rest, ref topSum);
        }

        Rebalance(x, numToFrequencyDictionary, numToIsInTopDictionary, top, rest, ref topSum);

        result[0] = topSum;

        for (var start = 1; start < result.Length; start++)
        {
            var outgoingNum = nums[start - 1];
            var incomingNum = nums[start + k - 1];

            RemoveNum(outgoingNum, numToFrequencyDictionary, numToIsInTopDictionary, top, rest, ref topSum);
            AddNum(incomingNum, numToFrequencyDictionary, numToIsInTopDictionary, top, rest, ref topSum);

            Rebalance(x, numToFrequencyDictionary, numToIsInTopDictionary, top, rest, ref topSum);

            result[start] = topSum;
        }

        return result;
    }

    private static void AddNum(
        int num,
        Dictionary<int, int> numToFrequencyDictionary,
        Dictionary<int, bool> numToIsInTopDictionary,
        SortedSet<FrequencyValue> top,
        SortedSet<FrequencyValue> rest,
        ref int topSum)
    {
        numToFrequencyDictionary.TryGetValue(num, out var oldFrequency);

        var newFrequency = oldFrequency + 1;

        numToFrequencyDictionary[num] = newFrequency;

        if (oldFrequency == 0)
        {
            rest.Add(new FrequencyValue(newFrequency, num));
            numToIsInTopDictionary[num] = false;

            return;
        }

        var wasInTop = numToIsInTopDictionary[num];
        var set = wasInTop ? top : rest;

        set.Remove(new FrequencyValue(oldFrequency, num));
        set.Add(new FrequencyValue(newFrequency, num));

        if (wasInTop)
        {
            topSum += num;
        }
    }

    private static void RemoveNum(
        int num,
        Dictionary<int, int> numToFrequencyDictionary,
        Dictionary<int, bool> numToIsInTopDictionary,
        SortedSet<FrequencyValue> top,
        SortedSet<FrequencyValue> rest,
        ref int topSum)
    {
        var oldFrequency = numToFrequencyDictionary[num];
        var newFrequency = oldFrequency - 1;

        var wasInTop = numToIsInTopDictionary[num];
        var set = wasInTop ? top : rest;

        set.Remove(new FrequencyValue(oldFrequency, num));

        if (newFrequency == 0)
        {
            numToFrequencyDictionary.Remove(num);
            numToIsInTopDictionary.Remove(num);

            if (wasInTop)
            {
                topSum -= num * oldFrequency;
            }

            return;
        }

        numToFrequencyDictionary[num] = newFrequency;

        set.Add(new FrequencyValue(newFrequency, num));

        if (wasInTop)
        {
            topSum -= num;
        }
    }

    private static void Rebalance(
        int x,
        Dictionary<int, int> numToFrequencyDictionary,
        Dictionary<int, bool> numToIsInTopDictionary,
        SortedSet<FrequencyValue> top,
        SortedSet<FrequencyValue> rest,
        ref int topSum)
    {
        var targetSize = Math.Min(x, numToFrequencyDictionary.Count);

        while (top.Count < targetSize)
        {
            var promoted = rest.Min;

            rest.Remove(promoted);
            top.Add(promoted);

            numToIsInTopDictionary[promoted.Num] = true;
            topSum += promoted.Num * promoted.Frequency;
        }

        while (top.Count > 0 && rest.Count > 0 && rest.Min.CompareTo(top.Max) < 0)
        {
            var promoted = rest.Min;
            var demoted = top.Max;

            rest.Remove(promoted);
            top.Remove(demoted);

            top.Add(promoted);
            rest.Add(demoted);

            numToIsInTopDictionary[promoted.Num] = true;
            numToIsInTopDictionary[demoted.Num] = false;

            topSum += promoted.Num * promoted.Frequency;
            topSum -= demoted.Num * demoted.Frequency;
        }
    }

    private readonly record struct FrequencyValue(int Frequency, int Num) : IComparable<FrequencyValue>
    {
        /// <inheritdoc />
        /// <remarks>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </remarks>
        public int CompareTo(FrequencyValue other)
        {
            var frequencyComparison = CompareToFrequency(other.Frequency);

            if (frequencyComparison == 0)
            {
                return CompareToNum(other.Num);
            }

            return frequencyComparison;
        }

        /// <summary>
        ///     Compares the frequency of this instance to <paramref name="frequency" />, ordering higher frequencies first.
        /// </summary>
        /// <param name="frequency">The frequency to compare to.</param>
        /// <returns>A negative number, zero, or a positive number depending on the comparison result.</returns>
        /// <remarks>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </remarks>
        private int CompareToFrequency(int frequency)
        {
            return frequency.CompareTo(Frequency);
        }

        /// <summary>
        ///     Compares the num of this instance to <paramref name="num" />, ordering larger values first.
        /// </summary>
        /// <param name="num">The value to compare to.</param>
        /// <returns>A negative number, zero, or a positive number depending on the comparison result.</returns>
        /// <remarks>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </remarks>
        private int CompareToNum(int num)
        {
            return num.CompareTo(Num);
        }
    }
}