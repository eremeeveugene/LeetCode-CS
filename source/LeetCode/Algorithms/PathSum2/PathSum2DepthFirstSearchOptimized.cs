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
public class PathSum2DepthFirstSearchOptimized : IPathSum2
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public IList<IList<int>> PathSum(TreeNode? root, int targetSum)
    {
        var result = new List<IList<int>>();
        var currentPath = new List<int>();

        PathSum(root, targetSum, currentPath, result);

        return result;
    }

    private static void PathSum(TreeNode? root, int targetSum, IList<int> currentPath, ICollection<IList<int>> result)
    {
        if (root == null)
        {
            return;
        }

        currentPath.Add(root.val);

        if (root.left == null && root.right == null && targetSum == root.val)
        {
            result.Add(new List<int>(currentPath));
        }
        else
        {
            PathSum(root.left, targetSum - root.val, currentPath, result);
            PathSum(root.right, targetSum - root.val, currentPath, result);
        }

        currentPath.RemoveAt(currentPath.Count - 1);
    }
}