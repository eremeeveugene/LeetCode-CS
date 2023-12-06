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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.BinaryTreeInorderTraversal;

public static class BinaryTreeInorderTraversalRecursive
{
    public static IList<int>? GetResult(TreeNode? treeNode)
    {
        if (treeNode == null) return new List<int>();

        return InOrderTraversal(treeNode);
    }

    private static List<int> InOrderTraversal(TreeNode treeNode)
    {
        var res = new List<int>();

        var left = new List<int>();

        if (treeNode.Left != null) left = InOrderTraversal(treeNode.Left);

        res.AddRange(left);
        res.Add(treeNode.Val);

        var right = new List<int>();

        if (treeNode.Right != null) right = InOrderTraversal(treeNode.Right);

        res.AddRange(right);

        return res;
    }
}