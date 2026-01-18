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
public sealed class ReverseStringPrefixTwoPointers : IReverseStringPrefix
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string ReversePrefix(string s, int k)
    {
        if (k == 1)
        {
            return s;
        }

        var sCharArray = s.ToCharArray();

        for (var i = 0; i < k / 2; i++)
        {
            (sCharArray[i], sCharArray[k - i - 1]) = (sCharArray[k - i - 1], sCharArray[i]);
        }

        return new string(sCharArray);
    }
}