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
public class FindTheLengthOfTheLongestCommonPrefixHashSet : IFindTheLengthOfTheLongestCommonPrefix
{
    /// <summary>
    ///     Time complexity - O(m * d1 + n * d2), where m is the number of elements in arr1, n is the number of elements in
    ///     arr2, d1 is the average number of digits in arr1, and d2 is the average number of digits in arr2
    ///     Space complexity - O(m * d1), where m is the number of elements in arr1, d1 is the average number of digits in arr1
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var arr1PrefixesHashSet = new HashSet<int>();

        for (var i = 0; i < arr1.Length; i++)
        {
            while (arr1[i] > 0)
            {
                arr1PrefixesHashSet.Add(arr1[i]);

                arr1[i] /= 10;
            }
        }

        var longestPrefix = 0;

        for (var i = 0; i < arr2.Length; i++)
        {
            while (arr2[i] > 0)
            {
                if (arr1PrefixesHashSet.Contains(arr2[i]))
                {
                    break;
                }

                arr2[i] /= 10;
            }

            if (arr2[i] > 0)
            {
                longestPrefix = Math.Max(longestPrefix, (int)Math.Floor(Math.Log10(arr2[i])) + 1);
            }
        }

        return longestPrefix;
    }
}