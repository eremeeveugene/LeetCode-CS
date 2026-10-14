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
public sealed class FindLuckyIntegerInAnArrayFrequencyArray : IFindLuckyIntegerInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindLucky(int[] arr)
    {
        var frequencyArray = new int[500];

        for (var i = 0; i < arr.Length; i++)
        {
            var number = arr[i];

            frequencyArray[number - 1]++;
        }

        for (var j = frequencyArray.Length - 1; j >= 0; j--)
        {
            if (j + 1 == frequencyArray[j])
            {
                return j + 1;
            }
        }

        return -1;
    }
}