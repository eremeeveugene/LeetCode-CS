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

namespace LeetCode.Algorithms.AddOneRowToTree;

/// <inheritdoc />
public class AddOneRowToTreeBreadthFirstSearch : IAddOneRowToTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="val"></param>
    /// <param name="depth"></param>
    /// <returns></returns>
    public TreeNode? AddOneRow(TreeNode? root, int val, int depth)
    {
        if (root == null)
        {
            return null;
        }

        if (depth == 1)
        {
            return new TreeNode(val, root);
        }

        var queue = new Queue<(TreeNode node, int level)>();

        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var (treeNode, level) = queue.Dequeue();

            if (level + 1 == depth)
            {
                treeNode.left = new TreeNode(val, treeNode.left);
                treeNode.right = new TreeNode(val, null, treeNode.right);
            }
            else
            {
                level++;

                if (treeNode.left != null)
                {
                    queue.Enqueue((treeNode.left, level));
                }

                if (treeNode.right != null)
                {
                    queue.Enqueue((treeNode.right, level));
                }
            }
        }

        return root;
    }
}