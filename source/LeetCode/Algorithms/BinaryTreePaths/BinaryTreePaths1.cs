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
using System.Text;

namespace LeetCode.Algorithms.BinaryTreePaths;

/// <inheritdoc />
public class BinaryTreePaths1 : IBinaryTreePaths
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n * h)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<string> BinaryTreePaths(TreeNode? root)
    {
        var treePaths = new List<string>();

        BuildTreePaths(root, new StringBuilder(), treePaths);

        return treePaths;
    }

    private static void BuildTreePaths(TreeNode? root, StringBuilder pathStringBuilder, IList<string> treePaths)
    {
        if (root == null)
        {
            return;
        }

        var pathStringBuilderLength = pathStringBuilder.Length;

        if (pathStringBuilder.Length > 0)
        {
            pathStringBuilder.Append("->");
        }

        pathStringBuilder.Append(root.val);

        if (root.left == null && root.right == null)
        {
            treePaths.Add(pathStringBuilder.ToString());
        }
        else
        {
            BuildTreePaths(root.left, pathStringBuilder, treePaths);
            BuildTreePaths(root.right, pathStringBuilder, treePaths);
        }

        pathStringBuilder.Length = pathStringBuilderLength;
    }
}