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

namespace LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

/// <inheritdoc />
public class FindTheLengthOfTheLongestCommonPrefixBruteForce : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <summary>
    ///     Time complexity - O(n * m * d), where n is the length of arr1, m is the length of arr2, d is the average number of
    ///     digits in the numbers of arr1 and arr2
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        return arr1.Aggregate(0,
            (current, num1) => arr2.Select(num2 => GetCommonPrefixLength(num1, num2)).Prepend(current).Max());
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