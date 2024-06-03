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

namespace LeetCode.Algorithms.ReverseString2;

/// <inheritdoc />
public class ReverseString2WithStringBuilder : IReverseString2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string ReverseStr(string s, int k)
    {
        var reverseStringBuilder = new StringBuilder();

        var reverse = true;
        var sIndex = 0;

        while (sIndex < s.Length)
        {
            IEnumerable<char> charArray;

            if (reverse)
            {
                charArray = s.Skip(sIndex).Take(k).Reverse();

                reverse = false;
            }
            else
            {
                charArray = s.Skip(sIndex).Take(k);

                reverse = true;
            }

            foreach (var c in charArray)
            {
                reverseStringBuilder.Append(c);
            }

            sIndex += k;
        }

        return reverseStringBuilder.ToString();
    }
}