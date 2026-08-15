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

namespace LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;

/// <inheritdoc />
public sealed class CreateBinaryTreeFromDescriptionsDictionary : ICreateBinaryTreeFromDescriptions
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public TreeNode? CreateBinaryTree(int[][] descriptions)
    {
        var nodeMap = new Dictionary<int, TreeNode>();
        var children = new HashSet<int>();

        for (var i = 0; i < descriptions.Length; i++)
        {
            var description = descriptions[i];
            var parentValue = description[0];
            var childValue = description[1];
            var isLeft = description[2] == 1;

            if (!nodeMap.TryGetValue(parentValue, out var parent))
            {
                parent = new TreeNode(parentValue);

                nodeMap[parentValue] = parent;
            }

            if (!nodeMap.TryGetValue(childValue, out var child))
            {
                child = new TreeNode(childValue);

                nodeMap[childValue] = child;
            }

            if (isLeft)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }

            children.Add(childValue);
        }

        for (var i = 0; i < descriptions.Length; i++)
        {
            var parentValue = descriptions[i][0];

            if (!children.Contains(parentValue))
            {
                return nodeMap[parentValue];
            }
        }

        return null;
    }
}