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
public class BinaryTreePostorderTraversalTwoStacks : IBinaryTreePostorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
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

        var traversalStack = new Stack<TreeNode>();
        var valueStack = new Stack<TreeNode>();

        traversalStack.Push(root);

        while (traversalStack.Count > 0)
        {
            var treeNode = traversalStack.Pop();

            valueStack.Push(treeNode);

            if (treeNode.left != null)
            {
                traversalStack.Push(treeNode.left);
            }

            if (treeNode.right != null)
            {
                traversalStack.Push(treeNode.right);
            }
        }

        while (valueStack.Count > 0)
        {
            var treeNode = valueStack.Pop();

            result.Add(treeNode.val);
        }

        return result;
    }
}