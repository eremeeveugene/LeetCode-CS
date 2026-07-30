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

namespace LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations2;

/// <inheritdoc />
public sealed class CheckIfStringsCanBeMadeEqualWithOperations2BruteForce : ICheckIfStringsCanBeMadeEqualWithOperations2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CheckStrings(string s1, string s2)
    {
        var n = s1.Length;

        var s1CharArray = s1.ToCharArray();

        for (var i = 0; i < n; i++)
        {
            if (s1CharArray[i] == s2[i])
            {
                continue;
            }

            var found = false;

            for (var j = i + 2; j < n; j += 2)
            {
                if (s1CharArray[j] != s2[i])
                {
                    continue;
                }

                (s1CharArray[j], s1CharArray[i]) = (s1CharArray[i], s1CharArray[j]);

                found = true;

                break;
            }

            if (found)
            {
                continue;
            }

            return false;
        }

        return true;
    }
}