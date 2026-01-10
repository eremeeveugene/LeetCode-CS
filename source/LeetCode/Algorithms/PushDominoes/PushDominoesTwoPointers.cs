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
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="dominoes"></param>
    /// <returns></returns>
    public string PushDominoes(string dominoes)
    {
        var dominoesCharArray = dominoes.ToCharArray();

        var left = -1;

        for (var right = 0; right <= dominoesCharArray.Length; right++)
        {
            var current = right < dominoesCharArray.Length ? dominoesCharArray[right] : 'R';
            var previous = left >= 0 ? dominoesCharArray[left] : 'L';

            if (current == '.')
            {
                continue;
            }

            if (right - left > 1)
            {
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

            left = right;
        }

        return new string(dominoesCharArray);
    }
}