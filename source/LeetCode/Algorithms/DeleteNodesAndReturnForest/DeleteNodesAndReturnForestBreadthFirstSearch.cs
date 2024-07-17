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

namespace LeetCode.Algorithms.DeleteNodesAndReturnForest;

/// <inheritdoc />
public class DeleteNodesAndReturnForestBreadthFirstSearch : IDeleteNodesAndReturnForest
{
    /// <summary>
    ///     Time complexity - O(n + d)
    ///     Space complexity - O(n + d)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="to_delete"></param>
    /// <returns></returns>
    public IList<TreeNode> DelNodes(TreeNode? root, int[] to_delete)
    {
        if (root == null)
        {
            return new List<TreeNode>();
        }

        var result = new List<TreeNode>();

        var toDeleteHashSet = new HashSet<int>(to_delete);
        var queue = new Queue<TreeNode>();

        var dummyNode = new TreeNode { left = root };

        queue.Enqueue(dummyNode);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.left != null)
            {
                queue.Enqueue(node.left);

                if (toDeleteHashSet.Contains(node.left.val))
                {
                    if (node.left.left != null && !toDeleteHashSet.Contains(node.left.left.val))
                    {
                        result.Add(node.left.left);
                    }

                    if (node.left.right != null && !toDeleteHashSet.Contains(node.left.right.val))
                    {
                        result.Add(node.left.right);
                    }

                    node.left = null;
                }
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);

                if (toDeleteHashSet.Contains(node.right.val))
                {
                    if (node.right.left != null && !toDeleteHashSet.Contains(node.right.left.val))
                    {
                        result.Add(node.right.left);
                    }

                    if (node.right.right != null && !toDeleteHashSet.Contains(node.right.right.val))
                    {
                        result.Add(node.right.right);
                    }

                    node.right = null;
                }
            }
        }

        if (dummyNode.left != null)
        {
            result.Add(dummyNode.left);
        }

        return result;
    }
}