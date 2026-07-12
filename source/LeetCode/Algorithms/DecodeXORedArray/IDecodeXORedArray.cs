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

namespace LeetCode.Algorithms.DecodeXORedArray;

/// <summary>
///     https://leetcode.com/problems/decode-xored-array/description/
/// </summary>
public interface IDecodeXORedArray
{
    /// <summary>
    ///     Decodes the original array from <paramref name="encoded" />, where each encoded element is the XOR of two
    ///     consecutive original elements and the first original element is <paramref name="first" />.
    /// </summary>
    /// <param name="encoded">The XOR-encoded array.</param>
    /// <param name="first">The first element of the original array.</param>
    /// <returns>The decoded original array.</returns>
    int[] Decode(int[] encoded, int first);
}