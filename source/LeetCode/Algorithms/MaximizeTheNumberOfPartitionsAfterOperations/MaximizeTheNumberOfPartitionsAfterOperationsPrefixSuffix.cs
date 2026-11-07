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

using System.Numerics;

namespace LeetCode.Algorithms.MaximizeTheNumberOfPartitionsAfterOperations;

/// <inheritdoc />
public sealed class MaximizeTheNumberOfPartitionsAfterOperationsPrefixSuffix : IMaximizeTheNumberOfPartitionsAfterOperations
{
    private const int AlphabetSize = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxPartitionsAfterOperations(string s, int k)
    {
        var n = s.Length;

        Span<int> suffixPartitionsCounts = stackalloc int[n];
        Span<int> suffixMasks = stackalloc int[n];
        Span<int> suffixDistinctCounts = stackalloc int[n];

        var partitionsCount = 0;
        var mask = 0;
        var distinctCount = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            suffixPartitionsCounts[i] = partitionsCount;
            suffixMasks[i] = mask;
            suffixDistinctCounts[i] = distinctCount;

            var c = s[i];

            AppendCharacter(c, k, ref partitionsCount, ref mask, ref distinctCount);
        }

        partitionsCount = 0;
        mask = 0;
        distinctCount = 0;

        var maxPartitionsCount = 0;

        for (var i = 0; i < n; i++)
        {
            var suffixPartitionsCount = suffixPartitionsCounts[i];
            var suffixMask = suffixMasks[i];
            var suffixDistinctCount = suffixDistinctCounts[i];

            var unionDistinctCount = BitOperations.PopCount((uint)(mask | suffixMask));

            var currentPartitionsCount = partitionsCount + suffixPartitionsCount + 2;

            if (distinctCount == k && suffixDistinctCount == k && unionDistinctCount < AlphabetSize)
            {
                currentPartitionsCount++;
            }
            else if (Math.Min(unionDistinctCount + 1, AlphabetSize) <= k)
            {
                currentPartitionsCount--;
            }

            maxPartitionsCount = Math.Max(maxPartitionsCount, currentPartitionsCount);

            var c = s[i];

            AppendCharacter(c, k, ref partitionsCount, ref mask, ref distinctCount);
        }

        return maxPartitionsCount;
    }

    /// <summary>
    ///     Appends a character to the current greedy partition, closing it and starting a new one when the character
    ///     would exceed the allowed number of distinct characters.
    /// </summary>
    /// <param name="c">The character to append.</param>
    /// <param name="k">The maximum number of distinct characters allowed in each partition.</param>
    /// <param name="partitionsCount">The number of closed partitions.</param>
    /// <param name="mask">The bitmask of distinct characters in the current partition.</param>
    /// <param name="distinctCount">The number of distinct characters in the current partition.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void AppendCharacter(char c, int k, ref int partitionsCount, ref int mask, ref int distinctCount)
    {
        var bit = 1 << (c - 'a');

        if ((mask & bit) != 0)
        {
            return;
        }

        if (distinctCount == k)
        {
            partitionsCount++;

            mask = bit;
            distinctCount = 1;

            return;
        }

        mask |= bit;
        distinctCount++;
    }
}