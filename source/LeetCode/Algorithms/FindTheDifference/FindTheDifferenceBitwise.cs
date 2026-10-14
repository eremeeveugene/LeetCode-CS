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

namespace LeetCode.Algorithms.FindTheDifference;

/// <inheritdoc />
public sealed class FindTheDifferenceBitwise : IFindTheDifference
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public char FindTheDifference(string s, string t)
    {
        var result = (char)0;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            result = (char)(result ^ c);
        }

        for (var i = 0; i < t.Length; i++)
        {
            var c = t[i];

            result = (char)(result ^ c);
        }

        return result;
    }
}