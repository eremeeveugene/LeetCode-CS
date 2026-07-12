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

namespace LeetCode.Algorithms.TotalCharactersInStringAfterTransformations1;

/// <inheritdoc />
public sealed class TotalCharactersInStringAfterTransformations1Counting : ITotalCharactersInStringAfterTransformations1
{
    private const int Modulo = 1_000_000_007;
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LengthAfterTransformations(string input, int transformationsCount)
    {
        Span<long> frequencies = stackalloc long[AlphabetLength];

        foreach (var c in input)
        {
            frequencies[c - 'a']++;
        }

        while (transformationsCount > 0)
        {
            for (var i = AlphabetLength - 1; i >= 0 && transformationsCount > 0; i--)
            {
                if (frequencies[i] > 0)
                {
                    var nextIndex = i + 1;

                    if (nextIndex >= AlphabetLength)
                    {
                        nextIndex = 0;
                    }

                    frequencies[nextIndex] = (frequencies[nextIndex] + frequencies[i]) % Modulo;
                }

                transformationsCount--;
            }
        }

        long result = 0;

        foreach (var frequency in frequencies)
        {
            result = (result + frequency) % Modulo;
        }

        return (int)result;
    }
}