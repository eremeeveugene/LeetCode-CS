// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <inheritdoc />
public sealed class FindModeInBinarySearchTreeDepthFirstSearchRecursive : IFindModeInBinarySearchTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] FindMode(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        var dictionary = new Dictionary<int, int>();

        FindMode(root, dictionary);

        var nums = new int[dictionary.Count];

        dictionary.Keys.CopyTo(nums, 0);

        var maxValue = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            maxValue = Math.Max(maxValue, dictionary[num]);
        }

        var modes = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (dictionary[num] == maxValue)
            {
                modes.Add(num);
            }
        }

        return modes.ToArray();
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