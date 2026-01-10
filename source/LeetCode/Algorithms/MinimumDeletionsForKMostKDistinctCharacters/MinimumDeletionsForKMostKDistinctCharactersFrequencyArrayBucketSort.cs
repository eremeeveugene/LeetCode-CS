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
public sealed class MinimumDeletionsForKMostKDistinctCharactersFrequencyArrayBucketSort :
    IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
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

        var buckets = new int[s.Length];

        foreach (var frequency in frequencyArray)
        {
            if (frequency > 0)
            {
                buckets[frequency - 1]++;
            }
        }

        var result = 0;

        for (var i = 0; i < s.Length && countToRemove > 0; i++)
        {
            while (buckets[i] > 0 && countToRemove > 0)
            {
                result += i + 1;

                buckets[i]--;

                countToRemove--;
            }
        }

        return result;
    }
}