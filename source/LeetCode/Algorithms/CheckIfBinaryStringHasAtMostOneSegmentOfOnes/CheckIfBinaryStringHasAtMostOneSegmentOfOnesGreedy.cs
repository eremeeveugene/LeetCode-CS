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

namespace LeetCode.Algorithms.CheckIfBinaryStringHasAtMostOneSegmentOfOnes;

/// <inheritdoc />
public sealed class CheckIfBinaryStringHasAtMostOneSegmentOfOnesGreedy : ICheckIfBinaryStringHasAtMostOneSegmentOfOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CheckOnesSegment(string s)
    {
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] > s[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}