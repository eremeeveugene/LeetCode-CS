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
public class SearchInBinarySearchTreeBreadthFirstSearch : ISearchInBinarySearchTree
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

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.val == val)
            {
                return node;
            }

            if (node.val < val)
            {
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            else
            {
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
            }
        }

        return null;
    }
}