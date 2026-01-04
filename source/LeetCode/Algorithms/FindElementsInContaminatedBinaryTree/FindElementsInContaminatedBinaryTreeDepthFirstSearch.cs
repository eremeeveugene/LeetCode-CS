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
public class FindElementsInContaminatedBinaryTreeDepthFirstSearch : IFindElementsInContaminatedBinaryTree
{
    private readonly TreeNode _root;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="root"></param>
    public FindElementsInContaminatedBinaryTreeDepthFirstSearch(TreeNode root)
    {
        _root = root;
        _root.val = 0;
    }

    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool Find(int target)
    {
        var node = _root;
        var stack = new Stack<bool>();

        while (target > 0)
        {
            stack.Push(target % 2 == 1);

            target = (target - 1) / 2;
        }

        while (stack.Count > 0)
        {
            node = stack.Pop() ? node.left : node.right;

            if (node == null)
            {
                return false;
            }
        }

        return true;
    }
}