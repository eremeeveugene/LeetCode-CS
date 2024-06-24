﻿using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <inheritdoc />
public class FindModeInBinarySearchTreeDepthFirstSearchStack : IFindModeInBinarySearchTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int[] FindMode(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        var dictionary = new Dictionary<int, int>();

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var treeNode = stack.Pop();

            if (!dictionary.TryAdd(treeNode.val, 1))
            {
                dictionary[treeNode.val]++;
            }

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }

            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }
        }

        var maxValue = dictionary.Values.Max();

        return dictionary.Where(i => i.Value == maxValue).Select(i => i.Key).ToArray();
    }
}