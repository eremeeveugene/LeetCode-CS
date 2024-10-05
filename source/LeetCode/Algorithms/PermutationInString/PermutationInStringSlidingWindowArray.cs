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

namespace LeetCode.Algorithms.PermutationInString;

/// <inheritdoc />
public class PermutationInStringSlidingWindowArray : IPermutationInString
{
    private const int ArrayLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n + m), where n is the length of s1 and m is the length of s2
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var s1Array = new int[ArrayLength];
        var s2Array = new int[ArrayLength];

        for (var i = 0; i < s1.Length; i++)
        {
            s1Array[s1[i] - 'a']++;
            s2Array[s2[i] - 'a']++;
        }

        for (var i = 0; i < s2.Length - s1.Length; i++)
        {
            if (AreArraysEqual(s1Array, s2Array))
            {
                return true;
            }

            s2Array[s2[i + s1.Length] - 'a']++;
            s2Array[s2[i] - 'a']--;
        }

        return AreArraysEqual(s1Array, s2Array);
    }

    private static bool AreArraysEqual(int[] array1, int[] array2)
    {
        for (var i = 0; i < 26; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }
}