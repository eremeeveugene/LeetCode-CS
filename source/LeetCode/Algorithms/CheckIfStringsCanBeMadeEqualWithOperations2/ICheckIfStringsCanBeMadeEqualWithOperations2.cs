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

namespace LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations2;

/// <summary>
///     https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-ii/description/
/// </summary>
public interface ICheckIfStringsCanBeMadeEqualWithOperations2
{
    /// <summary>
    ///     Determines whether <paramref name="s1" /> can be made equal to <paramref name="s2" /> by swapping characters at
    ///     indices of the same parity within either string.
    /// </summary>
    /// <param name="s1">The first string.</param>
    /// <param name="s2">The second string.</param>
    /// <returns><c>true</c> if the strings can be made equal using the allowed swaps; otherwise, <c>false</c>.</returns>
    bool CheckStrings(string s1, string s2);
}