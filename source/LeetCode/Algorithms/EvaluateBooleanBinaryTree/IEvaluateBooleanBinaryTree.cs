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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.EvaluateBooleanBinaryTree;

/// <summary>
///     https://leetcode.com/problems/evaluate-boolean-binary-tree/
/// </summary>
public interface IEvaluateBooleanBinaryTree
{
    /// <summary>
    ///     Evaluates the full binary tree rooted at <paramref name="root" />, where leaves hold boolean values and inner
    ///     nodes represent 'OR' and 'AND' operations.
    /// </summary>
    /// <param name="root">The root node of the boolean binary tree.</param>
    /// <returns><c>true</c> if the tree evaluates to true; otherwise, <c>false</c>.</returns>
    bool EvaluateTree(TreeNode root);
}