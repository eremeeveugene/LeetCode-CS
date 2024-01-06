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

namespace LeetCode.Algorithms.BinaryTreeInorderTraversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-inorder-traversal/description/
/// </summary>
public static class BinaryTreeInorderTraversalRecursive
{
    /// <summary>
    ///     Time complexity - O (n)
    /// </summary>
    /// <param name="treeNode"></param>
    /// <returns></returns>
    public static IList<int> GetResult(TreeNode? treeNode)
    {
        List<int> result = new();

        InOrderTraversal(treeNode, result);

        return result;
    }

    private static void InOrderTraversal(TreeNode? treeNode, ICollection<int> result)
    {
        if (treeNode == null)
        {
            return;
        }

        if (treeNode.left != null)
        {
            InOrderTraversal(treeNode.left, result);
        }

        result.Add(treeNode.val);

        if (treeNode.right != null)
        {
            InOrderTraversal(treeNode.right, result);
        }
    }
}