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

namespace LeetCode.Algorithms.AddBinary;

/// <summary>
///     https://leetcode.com/problems/add-binary/description/
/// </summary>
public interface IAddBinary
{
    /// <summary>
    ///     Adds the two binary strings <paramref name="a" /> and <paramref name="b" /> and returns their sum as a binary
    ///     string.
    /// </summary>
    /// <param name="a">The first binary string.</param>
    /// <param name="b">The second binary string.</param>
    /// <returns>The sum of the two binary strings as a binary string.</returns>
    string AddBinary(string a, string b);
}