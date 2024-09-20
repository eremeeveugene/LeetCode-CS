// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.ShortestPalindrome;

/// <inheritdoc />
public class ShortestPalindromeTwoPointers : IShortestPalindrome
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string ShortestPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }

        var left = 0;

        for (var right = s.Length - 1; right >= 0; right--)
        {
            if (s[right] == s[left])
            {
                left++;
            }
        }

        if (left == s.Length)
        {
            return s;
        }

        var resultStringBuilder = new StringBuilder();

        var nonPalindromeSuffix = s[left..];

        for (var i = nonPalindromeSuffix.Length - 1; i >= 0; i--)
        {
            resultStringBuilder.Append(nonPalindromeSuffix[i]);
        }

        resultStringBuilder.Append(ShortestPalindrome(s[..left]));
        resultStringBuilder.Append(nonPalindromeSuffix);

        return resultStringBuilder.ToString();
    }
}