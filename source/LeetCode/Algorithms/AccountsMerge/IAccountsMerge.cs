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

namespace LeetCode.Algorithms.AccountsMerge;

/// <summary>
///     https://leetcode.com/problems/accounts-merge/description/
/// </summary>
public interface IAccountsMerge
{
    /// <summary>
    ///     Merges accounts that share at least one common email, since such accounts belong to the same person.
    /// </summary>
    /// <param name="accounts">The accounts, each consisting of a name followed by the emails of that account.</param>
    /// <returns>
    ///     The merged accounts, each consisting of a name followed by its distinct emails in ordinal sorted order,
    ///     ordered by the index of the first input account that belongs to them.
    /// </returns>
    IList<IList<string>> AccountsMerge(IList<IList<string>> accounts);
}