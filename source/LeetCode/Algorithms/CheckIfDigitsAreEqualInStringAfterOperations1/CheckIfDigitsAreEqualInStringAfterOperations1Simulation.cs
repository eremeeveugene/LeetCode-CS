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

namespace LeetCode.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

/// <inheritdoc />
public class CheckIfDigitsAreEqualInStringAfterOperations1Simulation : ICheckIfDigitsAreEqualInStringAfterOperations1
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool HasSameDigits(string s)
    {
        while (s.Length > 2)
        {
            var newS = new char[s.Length - 1];

            for (var i = 0; i < s.Length - 1; i++)
            {
                newS[i] = (char)(((s[i] - '0' + s[i + 1] - '0') % 10) + '0');
            }

            s = new string(newS);
        }

        return s[0] == s[1];
    }
}