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

namespace LeetCode.Algorithms.FindElementsInContaminatedBinaryTree;

/// <summary>
///     https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree/description/
/// </summary>
public interface IFindElementsInContaminatedBinaryTree
{
    /// <summary>
    ///     Determines whether <paramref name="target" /> exists among the values recovered from the contaminated binary
    ///     tree.
    /// </summary>
    /// <param name="target">The value to search for in the recovered tree.</param>
    /// <returns><see langword="true" /> if <paramref name="target" /> exists in the tree; otherwise, <see langword="false" />.</returns>
    bool Find(int target);
}