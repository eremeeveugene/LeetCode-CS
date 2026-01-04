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

namespace LeetCode.Algorithms.FindLuckyIntegerInAnArray;

/// <inheritdoc />
public class FindLuckyIntegerInAnArrayFrequencyArray : IFindLuckyIntegerInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindLucky(int[] arr)
    {
        var frequencyArray = new int[500];

        foreach (var number in arr)
        {
            frequencyArray[number - 1]++;
        }

        for (var i = frequencyArray.Length - 1; i >= 0; i--)
        {
            if (i + 1 == frequencyArray[i])
            {
                return i + 1;
            }
        }

        return -1;
    }
}