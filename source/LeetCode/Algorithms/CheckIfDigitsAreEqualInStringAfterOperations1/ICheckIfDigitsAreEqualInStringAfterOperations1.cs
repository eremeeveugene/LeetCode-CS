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

namespace LeetCode.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

/// <summary>
///     https://leetcode.com/problems/check-if-digits-are-equal-in-string-after-operations-i/description/
/// </summary>
public interface ICheckIfDigitsAreEqualInStringAfterOperations1
{
    /// <summary>
    ///     Determines whether the final two digits of <paramref name="s" /> are equal after repeatedly replacing each pair
    ///     of consecutive digits with their sum modulo 10.
    /// </summary>
    /// <param name="s">The string consisting of digits.</param>
    /// <returns><c>true</c> if the final two digits are equal after the operations; otherwise, <c>false</c>.</returns>
    bool HasSameDigits(string s);
}