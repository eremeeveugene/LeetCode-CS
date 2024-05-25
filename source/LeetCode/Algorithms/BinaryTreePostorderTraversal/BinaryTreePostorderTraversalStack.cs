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

namespace LeetCode.Algorithms.BinaryTreePostorderTraversal;

/// <inheritdoc />
public class BinaryTreePostorderTraversalStack : IBinaryTreePostorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> PostorderTraversal(TreeNode? root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var result = new List<int>();

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var treeNode = stack.Pop();

            result.Insert(0, treeNode.val);

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }

            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }
        }

        return result;
    }
}