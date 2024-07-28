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

namespace LeetCode.Algorithms.SearchInBinarySearchTree;

/// <inheritdoc />
public class SearchInBinarySearchTreeDepthFirstSearchStack : ISearchInBinarySearchTree
{
    /// <summary>
    ///     Time complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    ///     Space complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root == null)
        {
            return null;
        }

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            if (node.val == val)
            {
                return node;
            }

            if (node.val < val)
            {
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }
            else
            {
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }
        }

        return null;
    }
}