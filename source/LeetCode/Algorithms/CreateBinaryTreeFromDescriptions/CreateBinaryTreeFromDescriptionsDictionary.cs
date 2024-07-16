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

namespace LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;

/// <inheritdoc />
public class CreateBinaryTreeFromDescriptionsDictionary : ICreateBinaryTreeFromDescriptions
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="descriptions"></param>
    /// <returns></returns>
    public TreeNode? CreateBinaryTree(int[][] descriptions)
    {
        var nodeMap = new Dictionary<int, TreeNode>();
        var children = new HashSet<int>();

        foreach (var description in descriptions)
        {
            var parentValue = description[0];
            var childValue = description[1];
            var isLeft = description[2] == 1;

            if (!nodeMap.ContainsKey(parentValue))
            {
                nodeMap[parentValue] = new TreeNode(parentValue);
            }

            if (!nodeMap.ContainsKey(childValue))
            {
                nodeMap[childValue] = new TreeNode(childValue);
            }

            var parent = nodeMap[parentValue];
            var child = nodeMap[childValue];

            if (isLeft)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }

            children.Add(childValue);
        }

        foreach (var key in nodeMap.Keys)
        {
            if (!children.Contains(key))
            {
                return nodeMap[key];
            }
        }

        return null;
    }
}