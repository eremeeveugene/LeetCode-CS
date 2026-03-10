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
public sealed class UsingRobotToPrintTheLexicographicallySmallestStringStack :
    IUsingRobotToPrintTheLexicographicallySmallestString
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public string RobotWithString(string input)
    {
        var n = input.Length;

        Span<int> charactersFrequency = stackalloc int[AlphabetLength];

        foreach (var character in input)
        {
            charactersFrequency[CharToIndex(character)]++;
        }

        var minIndex = 0;

        var bufferStack = new char[n];
        var bufferStackLastIndex = 0;

        var result = new char[n];
        var resultLength = 0;

        foreach (var character in input)
        {
            bufferStack[bufferStackLastIndex++] = character;

            charactersFrequency[CharToIndex(character)]--;

            while (minIndex < charactersFrequency.Length && charactersFrequency[minIndex] == 0)
            {
                minIndex++;
            }

            while (bufferStackLastIndex > 0 && (minIndex == AlphabetLength ||
                                                bufferStack[bufferStackLastIndex - 1] <= IndexToChar(minIndex)))
            {
                result[resultLength++] = bufferStack[--bufferStackLastIndex];
            }
        }

        while (bufferStackLastIndex > 0)
        {
            result[resultLength++] = bufferStack[--bufferStackLastIndex];
        }

        return new string(result);
    }

    private static int CharToIndex(char c)
    {
        return c - 'a';
    }

    private static char IndexToChar(int index)
    {
        return (char)(index + 'a');
    }
}