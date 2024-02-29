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

namespace LeetCode.Algorithms.EvenOddTree;

/// <inheritdoc />
public class EvenOddTreeBreadthFirst : IEvenOddTree
{
    /// <summary>
    ///     Time complexity - O(n), where n is the number of nodes in the binary tree
    ///     Space complexity - O(n) for a skewed tree, where n is the number of nodes in the binary tree. O(w) for a balanced
    ///     tree, where w is the maximum width of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsEvenOddTree(TreeNode? root)
    {
        if (root == null)
        {
            return false;
        }

        var queue = new Queue<(int, TreeNode)>();

        queue.Enqueue((0, root));

        var previousVal = 0;
        var currentLevel = 0;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (currentLevel != current.Item1)
            {
                previousVal = 0;
                currentLevel = current.Item1;
            }

            if (current.Item1 % 2 == 0)
            {
                if (current.Item2.val % 2 == 0)
                {
                    return false;
                }

                if (previousVal != 0 && current.Item2.val >= previousVal)
                {
                    return false;
                }

                previousVal = current.Item2.val;
            }
            else
            {
                if (current.Item2.val % 2 == 0)
                {
                    if (previousVal != 0 && current.Item2.val <= previousVal)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                previousVal = current.Item2.val;
            }

            if (current.Item2.right != null)
            {
                queue.Enqueue((current.Item1 + 1, current.Item2.right));
            }

            if (current.Item2.left != null)
            {
                queue.Enqueue((current.Item1 + 1, current.Item2.left));
            }
        }

        return true;
    }
}