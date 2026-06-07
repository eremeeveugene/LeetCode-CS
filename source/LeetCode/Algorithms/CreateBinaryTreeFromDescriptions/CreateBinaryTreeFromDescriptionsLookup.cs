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
public sealed class CreateBinaryTreeFromDescriptionsLookup : ICreateBinaryTreeFromDescriptions
{
    private const int LookupSize = 100_001;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public TreeNode? CreateBinaryTree(int[][] descriptions)
    {
        Span<bool> hasParentLookup = stackalloc bool[LookupSize];
        var nodesLookup = new TreeNode?[LookupSize];

        for (var i = 0; i < descriptions.Length; i++)
        {
            var description = descriptions[i];
            var parentValue = description[0];
            var childValue = description[1];
            var isLeft = description[2] == 1;

            var parent = nodesLookup[parentValue] ??= new TreeNode(parentValue);
            var child = nodesLookup[childValue] ??= new TreeNode(childValue);

            if (isLeft)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }

            hasParentLookup[childValue] = true;
        }

        for (var i = 0; i < descriptions.Length; i++)
        {
            var description = descriptions[i];
            var parentValue = description[0];

            if (hasParentLookup[parentValue])
            {
                continue;
            }

            return nodesLookup[parentValue];
        }

        return null;
    }
}