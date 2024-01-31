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

namespace LeetCode.Algorithms.CountTripletsThatCanFormTwoArraysOfEqualXOR;

/// <inheritdoc />
public class CountTripletsThatCanFormTwoArraysOfEqualXORIterative : ICountTripletsThatCanFormTwoArraysOfEqualXOR
{
    /// <summary>
    ///     Time complexity - O(n^2)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int CountTriplets(int[] arr)
    {
        var count = 0;

        var prefixXor = new int[arr.Length + 1];

        for (var i = 0; i < arr.Length; i++)
        {
            prefixXor[i + 1] = prefixXor[i] ^ arr[i];
        }

        for (var i = 0; i < arr.Length; i++)
        {
            for (var k = i + 1; k < arr.Length; k++)
            {
                if (prefixXor[i] == prefixXor[k + 1])
                {
                    count += k - i;
                }
            }
        }

        return count;
    }
}