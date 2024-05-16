// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class EvaluateBooleanBinaryTreeDepthFirstSearch : IEvaluateBooleanBinaryTree
{
    private const int OrOperation = 2;
    private const int AndOperation = 3;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(n log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool EvaluateTree(TreeNode? root)
    {
        return root != null && GetTreeEvaluation(root);
    }

    private static bool GetTreeEvaluation(TreeNode root)
    {
        if (root.left == null && root.right == null)
        {
            return root.val == 1;
        }

        var left = false;

        if (root.left != null)
        {
            left = GetTreeEvaluation(root.left);

            switch (root.val)
            {
                case OrOperation when left:
                    return true;
                case AndOperation when !left:
                    return false;
            }
        }

        var right = false;

        if (root.right != null)
        {
            right = GetTreeEvaluation(root.right);
        }

        if (root.val == OrOperation)
        {
            return left | right;
        }

        return left & right;
    }
}