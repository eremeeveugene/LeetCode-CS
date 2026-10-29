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
public sealed class FindModeInBinarySearchTreeDepthFirstSearchRecursive : FindModeInBinarySearchTreeBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public override int[] FindMode(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        var valToCountDictionary = new Dictionary<int, int>();

        CountVals(root, valToCountDictionary);

        return GetModes(valToCountDictionary);
    }

    /// <summary>
    ///     Counts the occurrences of every value in the subtree rooted at <paramref name="treeNode" />.
    /// </summary>
    /// <param name="treeNode">The root of the subtree.</param>
    /// <param name="valToCountDictionary">The occurrence counts, updated in place.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </remarks>
    private static void CountVals(TreeNode treeNode, Dictionary<int, int> valToCountDictionary)
    {
        IncrementCount(valToCountDictionary, treeNode.val);

        if (treeNode.left != null)
        {
            CountVals(treeNode.left, valToCountDictionary);
        }

        if (treeNode.right != null)
        {
            CountVals(treeNode.right, valToCountDictionary);
        }
    }
}