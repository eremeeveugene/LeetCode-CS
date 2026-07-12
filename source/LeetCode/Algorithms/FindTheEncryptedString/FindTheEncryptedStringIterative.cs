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

using System.Text;

namespace LeetCode.Algorithms.FindTheEncryptedString;

/// <inheritdoc />
public sealed class FindTheEncryptedStringIterative : IFindTheEncryptedString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string GetEncryptedString(string s, int k)
    {
        var resultStringBuilder = new StringBuilder(s.Length);

        for (var i = 0; i < s.Length; i++)
        {
            resultStringBuilder.Append(s[(i + k) % s.Length]);
        }

        return resultStringBuilder.ToString();
    }
}