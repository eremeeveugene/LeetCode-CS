// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.UniqueLength3PalindromicSubsequences;

/// <inheritdoc />
public class UniqueLength3PalindromicSubsequencesBruteForce : IUniqueLength3PalindromicSubsequences
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int CountPalindromicSubsequence(string s)
    {
        var palindromesHashSet = new HashSet<string>();

        for (var i = 2; i < s.Length; i++)
        {
            for (var j = 0; j <= i - 2; j++)
            {
                if (s[j] != s[i])
                {
                    continue;
                }

                for (var k = j + 1; k < i; k++)
                {
                    var palindromeStringBuilder = new StringBuilder();

                    palindromeStringBuilder.Append(s[i]);
                    palindromeStringBuilder.Append(s[k]);
                    palindromeStringBuilder.Append(s[j]);

                    var palindrome = palindromeStringBuilder.ToString();

                    palindromesHashSet.Add(palindrome);
                }
            }
        }

        return palindromesHashSet.Count;
    }
}