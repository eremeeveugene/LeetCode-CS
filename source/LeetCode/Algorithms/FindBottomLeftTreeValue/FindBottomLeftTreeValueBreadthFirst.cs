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

namespace LeetCode.Algorithms.FindBottomLeftTreeValue;

/// <inheritdoc />
public class FindBottomLeftTreeValueBreadthFirst : IFindBottomLeftTreeValue
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(w), where w is the maximum width of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int FindBottomLeftValue(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        TreeNode? current = null;

        while (queue.Count > 0)
        {
            current = queue.Dequeue();

            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }
        }

        return current?.val ?? 0;
    }
}