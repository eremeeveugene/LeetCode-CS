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

namespace LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

/// <inheritdoc />
public sealed class FindTheLengthOfTheLongestCommonPrefixBruteForce : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m * d), where n is the length of arr1, m is the length of arr2, d is the average number of
    ///     digits in the numbers of arr1 and arr2
    ///     Space complexity - O(1)
    /// </remarks>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var longestPrefix = 0;

        for (var i = 0; i < arr1.Length; i++)
        {
            var num1 = arr1[i];

            for (var j = 0; j < arr2.Length; j++)
            {
                var num2 = arr2[j];

                longestPrefix = Math.Max(longestPrefix, GetCommonPrefixLength(num1, num2));
            }
        }

        return longestPrefix;
    }

    private static int GetCommonPrefixLength(int num1, int num2)
    {
        var str1 = num1.ToString();
        var str2 = num2.ToString();

        var minLength = Math.Min(str1.Length, str2.Length);

        for (var i = 0; i < minLength; i++)
        {
            if (str1[i] != str2[i])
            {
                return i;
            }
        }

        return minLength;
    }
}