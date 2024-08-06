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
public class MergeTwoBinaryTreesDepthFirstSearchStack : IMergeTwoBinaryTrees
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m) for a skewed trees, O(log n + log m) for a balanced trees
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

        var root1Stack = new Stack<TreeNode>();
        var root2Stack = new Stack<TreeNode>();

        root1Stack.Push(root1);
        root2Stack.Push(root2);

        while (root1Stack.Count > 0 || root2Stack.Count > 0)
        {
            var root1Node = root1Stack.Pop();
            var root2Node = root2Stack.Pop();

            root1Node.val += root2Node.val;

            if (root1Node.left == null)
            {
                root1Node.left = root2Node.left;
            }
            else
            {
                if (root2Node.left != null)
                {
                    root1Stack.Push(root1Node.left);
                    root2Stack.Push(root2Node.left);
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
                    root1Stack.Push(root1Node.right);
                    root2Stack.Push(root2Node.right);
                }
            }
        }

        return root1;
    }
}