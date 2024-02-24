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

namespace LeetCode.Algorithms.PathSum2;

/// <inheritdoc />
public class PathSum2DepthFirstSearch : IPathSum2
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n*h)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public IList<IList<int>> PathSum(TreeNode? root, int targetSum)
    {
        return root == null ? [] : PathSum(new List<int> { root.val }, root, targetSum, root.val);
    }

    private static List<IList<int>> PathSum(IList<int> list, TreeNode root, int targetSum, int currentSum)
    {
        var result = new List<IList<int>>();

        if (root.left == null && root.right == null && currentSum == targetSum)
        {
            result.Add(list);
        }
        else
        {
            if (root.left != null)
            {
                result.AddRange(PathSum(new List<int>(list) { root.left.val }, root.left, targetSum,
                    currentSum + root.left.val));
            }

            if (root.right == null)
            {
                return result;
            }

            result.AddRange(PathSum(new List<int>(list) { root.right.val }, root.right, targetSum,
                currentSum + root.right.val));
        }

        return result;
    }
}