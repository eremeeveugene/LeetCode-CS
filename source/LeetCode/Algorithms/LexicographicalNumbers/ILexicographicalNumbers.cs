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

namespace LeetCode.Algorithms.LexicographicalNumbers;

/// <summary>
///     https://leetcode.com/problems/lexicographical-numbers/description/
/// </summary>
public interface ILexicographicalNumbers
{
    /// <summary>
    ///     Lists all integers in the range <c>[1, n]</c> in lexicographical (dictionary string) order.
    /// </summary>
    /// <param name="n">The upper bound of the range of integers to list.</param>
    /// <returns>The list of integers from <c>1</c> to <paramref name="n" /> in lexicographical order.</returns>
    IList<int> LexicalOrder(int n);
}