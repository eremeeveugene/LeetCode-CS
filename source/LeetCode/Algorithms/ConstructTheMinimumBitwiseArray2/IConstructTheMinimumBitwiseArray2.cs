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

namespace LeetCode.Algorithms.ConstructTheMinimumBitwiseArray2;

/// <summary>
///     https://leetcode.com/problems/construct-the-minimum-bitwise-array-ii/description/
/// </summary>
public interface IConstructTheMinimumBitwiseArray2
{
    /// <summary>
    ///     Constructs an array where each element is the smallest non-negative integer whose bitwise OR with itself plus
    ///     one equals the corresponding prime value in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The list of prime numbers to construct the minimum bitwise array from.</param>
    /// <returns>An array of minimum values satisfying the bitwise condition for each element of <paramref name="nums" />.</returns>
    int[] MinBitwiseArray(IList<int> nums);
}