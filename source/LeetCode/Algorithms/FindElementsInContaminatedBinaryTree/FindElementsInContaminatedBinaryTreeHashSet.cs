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

namespace LeetCode.Algorithms.FindElementsInContaminatedBinaryTree;

/// <inheritdoc />
public sealed class FindElementsInContaminatedBinaryTreeHashSet : IFindElementsInContaminatedBinaryTree
{
    private readonly HashSet<int> _hashSet = [];

    /// <summary>
    ///     Initializes a new instance of the <see cref="FindElementsInContaminatedBinaryTreeHashSet" /> class.
    /// </summary>
    /// <param name="root">The root of the contaminated binary tree.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public FindElementsInContaminatedBinaryTreeHashSet(TreeNode root)
    {
        var queue = new Queue<TreeNode>();

        root.val = 0;

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var treeNode = queue.Dequeue();

            _hashSet.Add(treeNode.val);

            if (treeNode.left != null)
            {
                treeNode.left.val = (2 * treeNode.val) + 1;

                queue.Enqueue(treeNode.left);
            }

            if (treeNode.right != null)
            {
                treeNode.right.val = (2 * treeNode.val) + 2;

                queue.Enqueue(treeNode.right);
            }
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool Find(int target)
    {
        return _hashSet.Contains(target);
    }
}