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
            var (nodeLevel, node) = queue.Dequeue();

            if (currentLevel != nodeLevel)
            {
                previousVal = 0;
                currentLevel = nodeLevel;
            }

            if (nodeLevel % 2 == 0)
            {
                if (node.val % 2 == 0)
                {
                    return false;
                }

                if (previousVal != 0 && node.val >= previousVal)
                {
                    return false;
                }
            }
            else
            {
                if (node.val % 2 != 0)
                {
                    return false;
                }

                if (previousVal != 0 && node.val <= previousVal)
                {
                    return false;
                }
            }

            previousVal = node.val;

            if (node.right != null)
            {
                queue.Enqueue((nodeLevel + 1, node.right));
            }

            if (node.left != null)
            {
                queue.Enqueue((nodeLevel + 1, node.left));
            }
        }

        return true;
    }
}