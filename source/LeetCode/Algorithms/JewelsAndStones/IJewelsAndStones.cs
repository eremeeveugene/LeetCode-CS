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

namespace LeetCode.Algorithms.JewelsAndStones;

/// <summary>
///     https://leetcode.com/problems/jewels-and-stones/description/
/// </summary>
public interface IJewelsAndStones
{
    /// <summary>
    ///     Counts how many characters of <paramref name="stones" /> are also jewels, where each character of
    ///     <paramref name="jewels" /> denotes a jewel type.
    /// </summary>
    /// <param name="jewels">The string whose characters represent the types of stones that are jewels.</param>
    /// <param name="stones">The string whose characters represent the stones owned.</param>
    /// <returns>The number of stones that are jewels.</returns>
    int NumJewelsInStones(string jewels, string stones);
}