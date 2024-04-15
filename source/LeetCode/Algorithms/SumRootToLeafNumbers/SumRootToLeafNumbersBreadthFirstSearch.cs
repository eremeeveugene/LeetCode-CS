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

namespace LeetCode.Algorithms.SumRootToLeafNumbers;

/// <inheritdoc />
public class SumRootToLeafNumbersBreadthFirstSearch : ISumRootToLeafNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumNumbers(TreeNode? root)
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
            var current = queue.Dequeue();

            if (current.left == null && current.right == null)
            {
                sum += current.val;
            }
            else
            {
                if (current.left != null)
                {
                    current.left.val += current.val * 10;

                    queue.Enqueue(current.left);
                }

                if (current.right == null)
                {
                    continue;
                }

                current.right.val += current.val * 10;

                queue.Enqueue(current.right);
            }
        }

        return sum;
    }
}