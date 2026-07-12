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

namespace LeetCode.Algorithms.BinaryPrefixDivisibleByFive;

/// <summary>
///     https://leetcode.com/problems/binary-prefix-divisible-by-5/description/
/// </summary>
public interface IBinaryPrefixDivisibleByFive
{
    /// <summary>
    ///     Determines, for each prefix of the binary array <paramref name="nums" />, whether the binary number formed by
    ///     that prefix is divisible by 5.
    /// </summary>
    /// <param name="nums">The binary array whose prefixes form binary numbers from most to least significant bit.</param>
    /// <returns>A list where the i-th element is <c>true</c> if the binary number formed by the first i + 1 bits is divisible by 5.</returns>
    IList<bool> PrefixesDivBy5(int[] nums);
}