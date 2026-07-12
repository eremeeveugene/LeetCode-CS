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
public sealed class FindSmallestLetterGreaterThanTargetBinarySearch : IFindSmallestLetterGreaterThanTarget
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public char NextGreatestLetter(char[] letters, char target)
    {
        var left = 0;
        var right = letters.Length - 1;

        var result = letters[0];

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (letters[mid] > target)
            {
                result = letters[mid];

                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }
}