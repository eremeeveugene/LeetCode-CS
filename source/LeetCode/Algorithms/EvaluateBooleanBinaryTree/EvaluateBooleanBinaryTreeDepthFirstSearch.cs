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

/// <inheritdoc />
public sealed class EvaluateBooleanBinaryTreeDepthFirstSearch : IEvaluateBooleanBinaryTree
{
    private const int OrOperation = 2;
    private const int AndOperation = 3;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(n log n) for a balanced tree
    /// </remarks>
    public bool EvaluateTree(TreeNode root)
    {
        return GetTreeEvaluation(root);
    }

    private static bool GetTreeEvaluation(TreeNode root)
    {
        if (root.left == null)
        {
            return root.val == 1;
        }

        var left = GetTreeEvaluation(root.left);

        switch (root.val)
        {
            case OrOperation when left:
                return true;
            case AndOperation when !left:
                return false;
        }

        var right = GetTreeEvaluation(root.right!);

        if (root.val == OrOperation)
        {
            return left | right;
        }

        return left & right;
    }
}