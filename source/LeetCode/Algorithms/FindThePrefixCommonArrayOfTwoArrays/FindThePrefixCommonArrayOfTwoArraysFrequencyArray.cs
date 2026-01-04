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

namespace LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

/// <inheritdoc />
public class FindThePrefixCommonArrayOfTwoArraysFrequencyArray : IFindThePrefixCommonArrayOfTwoArrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var result = new int[a.Length];
        var frequencyArray = new int[a.Length];
        var count = 0;

        for (var i = 0; i < a.Length; i++)
        {
            frequencyArray[a[i] - 1]++;

            if (frequencyArray[a[i] - 1] == 2)
            {
                count++;
            }

            frequencyArray[b[i] - 1]++;

            if (frequencyArray[b[i] - 1] == 2)
            {
                count++;
            }

            result[i] = count;
        }

        return result;
    }
}