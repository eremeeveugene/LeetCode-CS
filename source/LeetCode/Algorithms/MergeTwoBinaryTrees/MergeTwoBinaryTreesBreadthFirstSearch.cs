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

namespace LeetCode.Algorithms.MergeTwoBinaryTrees;

/// <inheritdoc />
public class MergeTwoBinaryTreesBreadthFirstSearch : IMergeTwoBinaryTrees
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="root1"></param>
    /// <param name="root2"></param>
    /// <returns></returns>
    public TreeNode? MergeTrees(TreeNode? root1, TreeNode? root2)
    {
        if (root1 == null && root2 == null)
        {
            return null;
        }

        if (root1 == null)
        {
            return root2;
        }

        if (root2 == null)
        {
            return root1;
        }

        var root1Queue = new Queue<TreeNode>();
        var root2Queue = new Queue<TreeNode>();

        root1Queue.Enqueue(root1);
        root2Queue.Enqueue(root2);

        while (root1Queue.Count > 0 || root2Queue.Count > 0)
        {
            var root1Node = root1Queue.Dequeue();
            var root2Node = root2Queue.Dequeue();

            root1Node.val += root2Node.val;

            if (root1Node.left == null)
            {
                root1Node.left = root2Node.left;
            }
            else
            {
                if (root2Node.left != null)
                {
                    root1Queue.Enqueue(root1Node.left);
                    root2Queue.Enqueue(root2Node.left);
                }
            }

            if (root1Node.right == null)
            {
                root1Node.right = root2Node.right;
            }
            else
            {
                if (root2Node.right != null)
                {
                    root1Queue.Enqueue(root1Node.right);
                    root2Queue.Enqueue(root2Node.right);
                }
            }
        }

        return root1;
    }
}