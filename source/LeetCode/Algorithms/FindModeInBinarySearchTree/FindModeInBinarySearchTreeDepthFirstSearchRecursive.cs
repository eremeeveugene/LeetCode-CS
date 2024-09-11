﻿using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <inheritdoc />
public class FindModeInBinarySearchTreeDepthFirstSearchRecursive : IFindModeInBinarySearchTree
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

        FindMode(root, dictionary);

        var maxValue = dictionary.Values.Max();

        return dictionary.Where(i => i.Value == maxValue).Select(i => i.Key).ToArray();
    }

    private static void FindMode(TreeNode treeNode, Dictionary<int, int> dictionary)
    {
        if (!dictionary.TryAdd(treeNode.val, 1))
        {
            dictionary[treeNode.val]++;
        }

        if (treeNode.left != null)
        {
            FindMode(treeNode.left, dictionary);
        }

        if (treeNode.right != null)
        {
            FindMode(treeNode.right, dictionary);
        }
    }
}