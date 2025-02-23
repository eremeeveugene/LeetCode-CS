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

namespace LeetCode.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;

/// <inheritdoc />
public class ConstructBinaryTreeFromPreorderAndPostorderTraversalRecursive :
    IConstructBinaryTreeFromPreorderAndPostorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="preorder"></param>
    /// <param name="postorder"></param>
    /// <returns></returns>
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        return ConstructFromPrePost(preorder, postorder, 0, preorder.Length - 1, 0)!;
    }

    private static TreeNode? ConstructFromPrePost(int[] preorder, int[] postorder, int preorderStart, int preorderEnd,
        int postorderStart)
    {
        if (preorderStart > preorderEnd)
        {
            return null;
        }

        if (preorderStart == preorderEnd)
        {
            return new TreeNode(preorder[preorderStart]);
        }

        var numOfNodesInLeft = 1;

        while (postorder[postorderStart + numOfNodesInLeft - 1] != preorder[preorderStart + 1])
        {
            numOfNodesInLeft++;
        }

        var left = ConstructFromPrePost(preorder, postorder, preorderStart + 1, preorderStart + numOfNodesInLeft,
            postorderStart);

        var right = ConstructFromPrePost(preorder, postorder, preorderStart + numOfNodesInLeft + 1, preorderEnd,
            postorderStart + numOfNodesInLeft);

        return new TreeNode(preorder[preorderStart], left, right);
    }
}