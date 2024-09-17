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

namespace LeetCode.Algorithms.LinkedListInBinaryTree;

/// <inheritdoc />
public class LinkedListInBinaryTreeDepthFirstSearch : ILinkedListInBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n * l), where n is the length of the tree and l is the length of the linked list
    ///     Space complexity - O(n + l) for an unbalanced tree, O(log n + l) for a balanced tree, where n is the length of the
    ///     tree and l is the length of the linked list
    /// </summary>
    /// <param name="head"></param>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        var treeNodeStack = new Stack<TreeNode>();

        treeNodeStack.Push(root);

        while (treeNodeStack.Count > 0)
        {
            var currentTreeNode = treeNodeStack.Pop();

            if (currentTreeNode.val == head.val)
            {
                if (IsLocalSubPath(head, currentTreeNode))
                {
                    return true;
                }
            }

            if (currentTreeNode.left != null)
            {
                treeNodeStack.Push(currentTreeNode.left);
            }

            if (currentTreeNode.right != null)
            {
                treeNodeStack.Push(currentTreeNode.right);
            }
        }

        return false;
    }

    private static bool IsLocalSubPath(ListNode? listNode, TreeNode? treeNode)
    {
        if (listNode == null)
        {
            return true;
        }

        if (treeNode == null)
        {
            return false;
        }

        if (listNode.val == treeNode.val)
        {
            return IsLocalSubPath(listNode.next, treeNode.left) || IsLocalSubPath(listNode.next, treeNode.right);
        }

        return false;
    }
}