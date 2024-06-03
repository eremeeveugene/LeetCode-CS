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

namespace LeetCode.Algorithms.DecodeXORedArray;

/// <inheritdoc />
public class DecodeXORedArrayIterative : IDecodeXORedArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="encoded"></param>
    /// <param name="first"></param>
    /// <returns></returns>
    public int[] Decode(int[] encoded, int first)
    {
        var result = new int[encoded.Length + 1];

        result[0] = first;

        for (var i = 0; i < encoded.Length; i++)
        {
            result[i + 1] = result[i] ^ encoded[i];
        }

        return result;
    }
}