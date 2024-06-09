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

namespace LeetCode.Algorithms.InvertBinaryTree;

/// <inheritdoc />
public class InvertBinaryTreeDepthFirstSearchStack : IInvertBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var treeNode = stack.Pop();

            (treeNode.left, treeNode.right) = (treeNode.right, treeNode.left);

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }

            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }
        }

        return root;
    }
}