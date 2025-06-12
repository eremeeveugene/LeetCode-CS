// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MinimumDeletionsForKMostKDistinctCharactersFrequencyArrayPriorityQueue :
    IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinDeletion(string s, int k)
    {
        var frequencyArray = new int['z' - 'a' + 1];

        foreach (var c in s)
        {
            frequencyArray[c - 'a']++;
        }

        var countToRemove = frequencyArray.Count(frequency => frequency > 0) - k;

        if (countToRemove <= 0)
        {
            return 0;
        }

        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var frequency in frequencyArray)
        {
            if (frequency > 0)
            {
                priorityQueue.Enqueue(frequency, frequency);
            }
        }

        var result = 0;

        for (var i = 0; i < countToRemove; i++)
        {
            result += priorityQueue.Dequeue();
        }

        return result;
    }
}