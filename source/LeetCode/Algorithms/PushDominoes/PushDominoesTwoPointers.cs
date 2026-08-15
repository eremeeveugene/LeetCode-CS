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

namespace LeetCode.Algorithms.PushDominoes;

/// <inheritdoc />
public sealed class PushDominoesTwoPointers : IPushDominoes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string PushDominoes(string dominoes)
    {
        var dominoesCharArray = dominoes.ToCharArray();

        var left = -1;

        for (var right = 0; right <= dominoesCharArray.Length; right++)
        {
            var current = right < dominoesCharArray.Length ? dominoesCharArray[right] : 'R';

            if (current == '.')
            {
                continue;
            }

            var previous = left >= 0 ? dominoesCharArray[left] : 'L';

            FillBetween(dominoesCharArray, left, right, previous, current);

            left = right;
        }

        return new string(dominoesCharArray);
    }

    private static void FillBetween(char[] dominoesCharArray, int left, int right, char previous, char current)
    {
        if (right - left <= 1)
        {
            return;
        }

        var currentLeft = left + 1;
        var currentRight = right - 1;

        if (previous == current)
        {
            while (currentLeft <= currentRight)
            {
                dominoesCharArray[currentLeft] = current;

                currentLeft++;
            }
        }
        else if (previous == 'R' && current == 'L')
        {
            while (currentLeft < currentRight)
            {
                dominoesCharArray[currentLeft] = 'R';
                dominoesCharArray[currentRight] = 'L';

                currentLeft++;
                currentRight--;
            }
        }
    }
}