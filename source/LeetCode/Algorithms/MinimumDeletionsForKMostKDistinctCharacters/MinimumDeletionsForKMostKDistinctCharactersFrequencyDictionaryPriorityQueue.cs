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

namespace LeetCode.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

/// <inheritdoc />
public sealed class MinimumDeletionsForKMostKDistinctCharactersFrequencyDictionaryPriorityQueue : IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinDeletion(string s, int k)
    {
        var frequencyDictionary = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !frequencyDictionary.TryAdd(c, 1)))
        {
            frequencyDictionary[c]++;
        }

        var countToRemove = frequencyDictionary.Values.Count - k;

        if (countToRemove <= 0)
        {
            return 0;
        }

        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var frequency in frequencyDictionary.Values)
        {
            priorityQueue.Enqueue(frequency, frequency);
        }

        var result = 0;

        for (var i = 0; i < countToRemove; i++)
        {
            result += priorityQueue.Dequeue();
        }

        return result;
    }
}