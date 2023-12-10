// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for a binary tree node
/// </summary>
public class TreeNode
{
    public TreeNode? Left;
    public TreeNode? Right;
    public int Val;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }

    public static TreeNode BuildTree(IList<int?> nums)
    {
        if (!nums.Any() || nums[0] == null) return new TreeNode();

        var root = new TreeNode(nums[0].Value);

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var i = 1;

        while (queue.Count > 0 && i < nums.Count)
        {
            var current = queue.Dequeue();

            // Process the left child
            if (i < nums.Count && nums[i].HasValue)
            {
                current.Left = new TreeNode(nums[i].Value);
                queue.Enqueue(current.Left);
            }

            i++;

            // Process the right child
            if (i < nums.Count && nums[i].HasValue)
            {
                current.Right = new TreeNode(nums[i].Value);
                queue.Enqueue(current.Right);
            }

            i++;
        }

        return root;
    }
}