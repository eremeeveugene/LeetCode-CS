// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class FindElementsInContaminatedBinaryTreeHashSet : IFindElementsInContaminatedBinaryTree
{
    private readonly HashSet<int> _hashSet = [];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
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

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool Find(int target)
    {
        return _hashSet.Contains(target);
    }
}