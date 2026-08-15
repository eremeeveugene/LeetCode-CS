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

namespace LeetCode.Algorithms.FindSmallestLetterGreaterThanTarget;

/// <inheritdoc />
public sealed class FindSmallestLetterGreaterThanTargetGreedy : IFindSmallestLetterGreaterThanTarget
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public char NextGreatestLetter(char[] letters, char target)
    {
        for (var i = 0; i < letters.Length; i++)
        {
            var letter = letters[i];

            if (letter > target)
            {
                return letter;
            }
        }

        return letters[0];
    }
}