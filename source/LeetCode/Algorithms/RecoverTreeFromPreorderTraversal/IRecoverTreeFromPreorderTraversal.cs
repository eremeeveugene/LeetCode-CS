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

namespace LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;

/// <summary>
///     https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/description/
/// </summary>
public interface IRecoverTreeFromPreorderTraversal
{
    TreeNode? RecoverFromPreorder(string traversal);
}