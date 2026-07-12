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

namespace LeetCode.Algorithms.MovePiecesToObtainString;

/// <inheritdoc />
public sealed class MovePiecesToObtainStringTwoPointers : IMovePiecesToObtainString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CanChange(string start, string target)
    {
        var startIndex = 0;
        var targetIndex = 0;

        while (true)
        {
            startIndex = SkipBlanks(start, startIndex);
            targetIndex = SkipBlanks(target, targetIndex);

            if (startIndex == start.Length || targetIndex == target.Length)
            {
                return startIndex == start.Length && targetIndex == target.Length;
            }

            if (!IsMatchingPiece(start[startIndex], target[targetIndex], startIndex, targetIndex))
            {
                return false;
            }

            startIndex++;
            targetIndex++;
        }
    }

    private static int SkipBlanks(string value, int index)
    {
        while (index < value.Length && value[index] == '_')
        {
            index++;
        }

        return index;
    }

    private static bool IsMatchingPiece(char startPiece, char targetPiece, int startIndex, int targetIndex)
    {
        if (startPiece != targetPiece)
        {
            return false;
        }

        if (startPiece == 'L' && targetIndex > startIndex)
        {
            return false;
        }

        return startPiece != 'R' || targetIndex >= startIndex;
    }
}