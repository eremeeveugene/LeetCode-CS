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

/// <inheritdoc />
public class BinaryTreeInorderTraversalRecursive : IBinaryTreeInorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="treeNode"></param>
    /// <returns></returns>
    public IList<int> InorderTraversal(TreeNode? treeNode)
    {
        if (treeNode == null)
        {
            return new List<int> { 0 };
        }

        List<int> result = [];

        InorderTraversal(treeNode, result);

        return result;
    }

    private static void InorderTraversal(TreeNode treeNode, ICollection<int> result)
    {
        if (treeNode.left != null)
        {
            InorderTraversal(treeNode.left, result);
        }

        result.Add(treeNode.val);

        if (treeNode.right != null)
        {
            InorderTraversal(treeNode.right, result);
        }
    }
}