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

namespace LeetCode.Algorithms.CousinsInBinaryTree2;

/// <inheritdoc />
public class CousinsInBinaryTree2BreadthFirstSearch : ICousinsInBinaryTree2
{
    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        var levelSums = new List<int>();

        while (queue.Count > 0)
        {
            var levelSum = 0;
            var levelSize = queue.Count;

            for (var i = 0; i < levelSize; i++)
            {
                var currentNode = queue.Dequeue();

                levelSum += currentNode.val;

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }

            levelSums.Add(levelSum);
        }

        queue.Enqueue(root);

        var levelIndex = 1;

        root.val = 0;

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;

            for (var i = 0; i < levelSize; i++)
            {
                var currentNode = queue.Dequeue();

                var sum = (currentNode.left?.val ?? 0) + (currentNode.right?.val ?? 0);

                if (currentNode.left != null)
                {
                    currentNode.left.val = levelSums[levelIndex] - sum;

                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    currentNode.right.val = levelSums[levelIndex] - sum;

                    queue.Enqueue(currentNode.right);
                }
            }

            levelIndex++;
        }

        return root;
    }
}