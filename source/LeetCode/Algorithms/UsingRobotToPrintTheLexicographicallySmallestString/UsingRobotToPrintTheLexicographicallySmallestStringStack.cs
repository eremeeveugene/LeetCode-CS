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

namespace LeetCode.Algorithms.UsingRobotToPrintTheLexicographicallySmallestString;

/// <inheritdoc />
public sealed class UsingRobotToPrintTheLexicographicallySmallestStringStack : IUsingRobotToPrintTheLexicographicallySmallestString
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RobotWithString(string s)
    {
        var n = s.Length;

        Span<int> charactersFrequency = stackalloc int[AlphabetLength];

        for (var i = 0; i < s.Length; i++)
        {
            var character = s[i];
            var characterIndex = CharacterToIndex(character);

            charactersFrequency[characterIndex]++;
        }

        var minIndex = 0;

        var bufferStack = new char[n];
        var bufferStackLastIndex = 0;

        var result = new char[n];
        var resultLength = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var character = s[i];

            bufferStack[bufferStackLastIndex++] = character;

            charactersFrequency[CharacterToIndex(character)]--;

            while (minIndex < charactersFrequency.Length && charactersFrequency[minIndex] == 0)
            {
                minIndex++;
            }

            while (bufferStackLastIndex > 0 && (minIndex == AlphabetLength || bufferStack[bufferStackLastIndex - 1] <= IndexToCharacter(minIndex)))
            {
                result[resultLength++] = bufferStack[--bufferStackLastIndex];
            }
        }

        return new string(result);
    }

    private static int CharacterToIndex(char c)
    {
        return c - 'a';
    }

    private static char IndexToCharacter(int index)
    {
        return (char)(index + 'a');
    }
}