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

namespace LeetCode.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

/// <inheritdoc />
public class MakeStringSubsequenceUsingCyclicIncrementsTwoPointers : IMakeStringSubsequenceUsingCyclicIncrements
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public bool CanMakeSubsequence(string str1, string str2)
    {
        if (str2.Length > str1.Length)
        {
            return false;
        }

        var str1Index = 0;
        var str2Index = 0;

        while (str1Index < str1.Length && str2Index < str2.Length)
        {
            if (str1[str1Index] == str2[str2Index] || (str1[str1Index] == 'z' && str2[str2Index] == 'a') ||
                str1[str1Index] + 1 == str2[str2Index])
            {
                str2Index++;
            }

            str1Index++;
        }

        return str2Index == str2.Length;
    }
}