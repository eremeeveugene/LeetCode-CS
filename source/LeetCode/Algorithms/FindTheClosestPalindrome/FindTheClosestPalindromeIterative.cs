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

using System.Globalization;
using System.Numerics;
using System.Text;

namespace LeetCode.Algorithms.FindTheClosestPalindrome;

/// <inheritdoc />
public sealed class FindTheClosestPalindromeIterative : IFindTheClosestPalindrome
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(L), where L is the length of the string
    ///     Space complexity - O(L), where L is the length of the string
    /// </remarks>
    public string NearestPalindromic(string n)
    {
        var num = BigInteger.Parse(n, CultureInfo.InvariantCulture);

        var candidates = new List<BigInteger> { BigInteger.Pow(10, n.Length - 1) - 1, BigInteger.Pow(10, n.Length) + 1 };

        var prefix = BigInteger.Parse(n[..((n.Length + 1) / 2)], CultureInfo.InvariantCulture);

        for (var i = prefix - 1; i <= prefix + 1; i++)
        {
            var candidate = BuildPalindrome(i, n.Length % 2 == 0);

            candidates.Add(BigInteger.Parse(candidate, CultureInfo.InvariantCulture));
        }

        var minDiff = BigInteger.Abs(candidates[0] - num);
        var result = candidates[0];

        for (var i = 0; i < candidates.Count; i++)
        {
            var candidate = candidates[i];

            if (candidate == num)
            {
                continue;
            }

            var diff = BigInteger.Abs(candidate - num);

            if (diff >= minDiff && (diff != minDiff || candidate >= result))
            {
                continue;
            }

            minDiff = diff;
            result = candidate;
        }

        return result.ToString(CultureInfo.InvariantCulture);
    }

    private static string BuildPalindrome(BigInteger prefix, bool isEven)
    {
        var stringBuilder = new StringBuilder();

        var prefixString = prefix.ToString(CultureInfo.InvariantCulture);

        stringBuilder.Append(prefixString);

        var mirroredLength = prefixString.Length - (isEven ? 0 : 1);

        for (var i = mirroredLength - 1; i >= 0; i--)
        {
            var c = prefixString[i];

            stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }
}