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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeStringKSpecial;

/// <inheritdoc />
public sealed class MinimumDeletionsToMakeStringKSpecialFrequencyArray : IMinimumDeletionsToMakeStringKSpecial
{
    private const int AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="word"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinimumDeletions(string word, int k)
    {
        var wordLength = word.Length;

        Span<int> frequencyArray = stackalloc int[AlphabetLength];

        for (var i = 0; i < wordLength; i++)
        {
            frequencyArray[word[i] - 'a']++;
        }

        var minimumDeletions = int.MaxValue;

        for (var i = 0; i < AlphabetLength; i++)
        {
            var targetFrequency = frequencyArray[i];

            if (targetFrequency == 0)
            {
                continue;
            }

            var deletions = 0;

            for (var j = 0; j < AlphabetLength; j++)
            {
                if (i == j)
                {
                    continue;
                }

                var frequency = frequencyArray[j];

                if (frequency == 0)
                {
                    continue;
                }

                if (targetFrequency > frequency)
                {
                    deletions += frequency;

                    continue;
                }

                var upperBound = targetFrequency + k;

                if (frequency > upperBound)
                {
                    deletions += frequency - upperBound;
                }
            }

            minimumDeletions = int.Min(minimumDeletions, deletions);
        }

        return minimumDeletions;
    }
}