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

namespace LeetCode.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

/// <summary>
///     https://leetcode.com/problems/max-difference-you-can-get-from-changing-an-integer/description/
/// </summary>
public interface IMaxDifferenceYouCanGetFromChangingAnInteger
{
    /// <summary>
    ///     Computes the maximum difference obtainable by replacing one digit value with another (each occurrence) in
    ///     <paramref name="num" /> to form the largest possible value, and separately doing so to form the smallest
    ///     possible value.
    /// </summary>
    /// <param name="num">The positive integer whose digits may be replaced.</param>
    /// <returns>The difference between the largest and smallest values obtainable from <paramref name="num" /> by a single digit-replacement rule.</returns>
    int MaxDiff(int num);
}