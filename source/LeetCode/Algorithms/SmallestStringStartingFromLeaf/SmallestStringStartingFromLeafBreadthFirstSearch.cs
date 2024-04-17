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

namespace LeetCode.Algorithms.SmallestStringStartingFromLeaf;

/// <inheritdoc />
public class SmallestStringStartingFromLeafBreadthFirstSearch : ISmallestStringStartingFromLeaf
{
    /// <summary>
    ///     Time complexity - O(n) for a balanced tree, O(n^2) for a skewed tree
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public string? SmallestFromLeaf(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        string? smallestString = null;

        var queue = new Queue<(TreeNode node, string path)>();

        queue.Enqueue((root, ""));

        while (queue.Count > 0)
        {
            var (currentNode, path) = queue.Dequeue();
            var currentPath = (char)('a' + currentNode.val) + path;

            if (currentNode.left == null && currentNode.right == null)
            {
                var reversePath = new string(currentPath.Reverse().ToArray());

                if (smallestString == null || string.Compare(reversePath, smallestString, StringComparison.Ordinal) < 0)
                {
                    smallestString = reversePath;
                }
            }

            if (currentNode.left != null)
            {
                queue.Enqueue((currentNode.left, currentPath));
            }

            if (currentNode.right != null)
            {
                queue.Enqueue((currentNode.right, currentPath));
            }
        }

        return smallestString;
    }
}