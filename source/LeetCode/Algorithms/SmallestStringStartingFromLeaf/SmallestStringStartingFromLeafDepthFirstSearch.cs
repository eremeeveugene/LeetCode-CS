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
public class SmallestStringStartingFromLeafDepthFirstSearch : ISmallestStringStartingFromLeaf
{
    private string? _smallestString;

    /// <summary>
    ///     Time complexity - O(n) for a balanced tree, O(n^2) for a skewed tree
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public string? SmallestFromLeaf(TreeNode? root)
    {
        FindSmallest(root, string.Empty);

        return _smallestString;
    }

    private void FindSmallest(TreeNode? node, string currentPath)
    {
        if (node == null)
        {
            return;
        }

        var currentChar = (char)('a' + node.val);
        var newPath = currentChar + currentPath;

        if (node.left == null && node.right == null)
        {
            if (_smallestString == null || string.CompareOrdinal(newPath, _smallestString) < 0)
            {
                _smallestString = newPath;
            }
        }

        FindSmallest(node.left, newPath);
        FindSmallest(node.right, newPath);
    }
}