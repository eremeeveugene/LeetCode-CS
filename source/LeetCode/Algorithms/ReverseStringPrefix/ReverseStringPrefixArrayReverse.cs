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

namespace LeetCode.Algorithms.ReverseStringPrefix;

/// <inheritdoc />
public sealed class ReverseStringPrefixArrayReverse : IReverseStringPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string ReversePrefix(string s, int k)
    {
        if (k == 1)
        {
            return s;
        }

        var sCharArray = s.ToCharArray();

        Array.Reverse(sCharArray, 0, k);

        return new string(sCharArray);
    }
}