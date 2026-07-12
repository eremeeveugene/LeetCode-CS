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

using System.Text;

namespace LeetCode.Algorithms.ConstructStringWithRepeatLimit;

/// <inheritdoc />
public sealed class ConstructStringWithRepeatLimitPriorityQueue : IConstructStringWithRepeatLimit
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log k)
    ///     Space complexity - O(k)
    /// </remarks>
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        var frequencyDictionary = new Dictionary<char, int>();

        foreach (var character in s.Where(character => !frequencyDictionary.TryAdd(character, 1)))
        {
            frequencyDictionary[character]++;
        }

        var frequencyPriorityQueue = new PriorityQueue<char, char>();

        foreach (var character in frequencyDictionary.Keys)
        {
            frequencyPriorityQueue.Enqueue(character, (char)('z' - character));
        }

        var resultStringBuilder = new StringBuilder();

        while (frequencyPriorityQueue.Count > 0)
        {
            var character = frequencyPriorityQueue.Dequeue();

            var count = frequencyDictionary[character];

            var charactersCount = Math.Min(count, repeatLimit);

            for (var i = 0; i < charactersCount; i++)
            {
                resultStringBuilder.Append(character);
            }

            frequencyDictionary[character] -= charactersCount;

            if (frequencyDictionary[character] <= 0 || frequencyPriorityQueue.Count <= 0)
            {
                continue;
            }

            var nextCharacter = frequencyPriorityQueue.Dequeue();

            resultStringBuilder.Append(nextCharacter);

            frequencyDictionary[nextCharacter]--;

            if (frequencyDictionary[nextCharacter] > 0)
            {
                frequencyPriorityQueue.Enqueue(nextCharacter, (char)('z' - nextCharacter));
            }

            frequencyPriorityQueue.Enqueue(character, (char)('z' - character));
        }

        return resultStringBuilder.ToString();
    }
}