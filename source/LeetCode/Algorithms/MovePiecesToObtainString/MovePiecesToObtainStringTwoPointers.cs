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
public class MovePiecesToObtainStringTwoPointers : IMovePiecesToObtainString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool CanChange(string start, string target)
    {
        var startIndex = 0;
        var targetIndex = 0;

        while (startIndex < start.Length && targetIndex < target.Length)
        {
            while (startIndex < start.Length && start[startIndex] == '_')
            {
                startIndex++;
            }

            while (targetIndex < target.Length && target[targetIndex] == '_')
            {
                targetIndex++;
            }

            if (startIndex == start.Length && targetIndex == target.Length)
            {
                return true;
            }

            if (startIndex == start.Length || targetIndex == target.Length)
            {
                return false;
            }

            if (start[startIndex] != target[targetIndex])
            {
                return false;
            }

            if (start[startIndex] == 'L' && targetIndex > startIndex)
            {
                return false;
            }

            if (start[startIndex] == 'R' && targetIndex < startIndex)
            {
                return false;
            }

            startIndex++;
            targetIndex++;
        }

        while (startIndex < start.Length && start[startIndex] == '_')
        {
            startIndex++;
        }

        while (targetIndex < target.Length && target[targetIndex] == '_')
        {
            targetIndex++;
        }

        return startIndex == start.Length && targetIndex == target.Length;
    }
}