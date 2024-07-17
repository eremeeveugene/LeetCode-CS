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

namespace LeetCode.Algorithms.DeleteNodesAndReturnForest;

/// <inheritdoc />
public class DeleteNodesAndReturnForestDepthFirstSearchRecursive : IDeleteNodesAndReturnForest
{
    /// <summary>
    ///     Time complexity - O(n + d)
    ///     Space complexity - O(n + d)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="to_delete"></param>
    /// <returns></returns>
    public IList<TreeNode> DelNodes(TreeNode? root, int[] to_delete)
    {
        if (root == null)
        {
            return new List<TreeNode>();
        }

        var result = new List<TreeNode>();

        var toDeleteHashSet = new HashSet<int>(to_delete);

        DelNodes(root, true, toDeleteHashSet, result);

        return result;
    }

    private static TreeNode? DelNodes(TreeNode? node, bool isRoot, IReadOnlySet<int> toDeleteHashSet,
        ICollection<TreeNode> result)
    {
        if (node == null)
        {
            return null;
        }

        var toBeDeleted = toDeleteHashSet.Contains(node.val);

        if (isRoot && !toBeDeleted)
        {
            result.Add(node);
        }

        node.left = DelNodes(node.left, toBeDeleted, toDeleteHashSet, result);
        node.right = DelNodes(node.right, toBeDeleted, toDeleteHashSet, result);

        return toBeDeleted ? null : node;
    }
}