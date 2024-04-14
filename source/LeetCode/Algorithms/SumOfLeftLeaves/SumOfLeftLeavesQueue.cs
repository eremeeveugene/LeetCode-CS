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

namespace LeetCode.Algorithms.SumOfLeftLeaves;

/// <inheritdoc />
public class SumOfLeftLeavesQueue : ISumOfLeftLeaves
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for skewed tree, O(log n) for balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumOfLeftLeaves(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var sum = 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var treeNode = queue.Dequeue();

            if (treeNode.left != null)
            {
                if (treeNode.left.left == null && treeNode.left.right == null)
                {
                    sum += treeNode.left.val;
                }
                else
                {
                    queue.Enqueue(treeNode.left);
                }
            }

            if (treeNode.right != null)
            {
                queue.Enqueue(treeNode.right);
            }
        }

        return sum;
    }
}