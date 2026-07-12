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
public sealed class FindTheLengthOfTheLongestCommonPrefixHashSetOptimized : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) * d), where d is the maximum number of digits
    ///     Space complexity - O(n * d), for storing prefixes from arr1
    /// </remarks>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var arr1PrefixesHashSet = new HashSet<int>();

        for (var i = 0; i < arr1.Length; i++)
        {
            var value = arr1[i];

            while (value > 0)
            {
                arr1PrefixesHashSet.Add(value);

                value /= 10;
            }
        }

        var longestPrefix = 0;

        for (var i = 0; i < arr2.Length; i++)
        {
            var value = arr2[i];

            while (value > 0)
            {
                if (arr1PrefixesHashSet.Contains(value))
                {
                    var prefixLength = GetDigitsCount(value);

                    longestPrefix = Math.Max(longestPrefix, prefixLength);

                    break;
                }

                value /= 10;
            }
        }

        return longestPrefix;
    }

    private static int GetDigitsCount(int value)
    {
        return value switch
        {
            > 999999999 => 10,
            > 99999999 => 9,
            > 9999999 => 8,
            > 999999 => 7,
            > 99999 => 6,
            > 9999 => 5,
            > 999 => 4,
            > 99 => 3,
            > 9 => 2,
            _ => 1
        };
    }
}