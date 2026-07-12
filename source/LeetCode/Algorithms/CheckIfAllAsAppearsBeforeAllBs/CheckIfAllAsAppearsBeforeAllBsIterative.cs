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

namespace LeetCode.Algorithms.CheckIfAllAsAppearsBeforeAllBs;

/// <inheritdoc />
public sealed class CheckIfAllAsAppearsBeforeAllBsIterative : ICheckIfAllAsAppearsBeforeAllBs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CheckString(string s)
    {
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s[i] > s[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}