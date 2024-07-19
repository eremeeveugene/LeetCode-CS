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

namespace LeetCode.Algorithms.NumberOfGoodLeafNodesPairs;

/// <inheritdoc />
public class NumberOfGoodLeafNodesPairsDepthFirstSearch : INumberOfGoodLeafNodesPairs
{
    /// <summary>
    ///     Time complexity - O(n * d^2)
    ///     Space complexity - O(n * d)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="distance"></param>
    /// <returns></returns>
    public int CountPairs(TreeNode? root, int distance)
    {
        var result = 0;

        CountPairs(root, distance, ref result);

        return result;
    }

    private static List<int> CountPairs(TreeNode? node, int distance, ref int result)
    {
        if (node == null)
        {
            return [];
        }

        if (node.left == null && node.right == null)
        {
            return [1];
        }

        var leftDistances = CountPairs(node.left, distance, ref result);
        var rightDistances = CountPairs(node.right, distance, ref result);

        result += leftDistances.Sum(leftDistance =>
            rightDistances.Count(rightDistance => leftDistance + rightDistance <= distance));

        var currentDistances = new List<int>();

        foreach (var leftDistance in leftDistances)
        {
            if (leftDistance + 1 <= distance)
            {
                currentDistances.Add(leftDistance + 1);
            }
        }

        foreach (var rightDistance in rightDistances)
        {
            if (rightDistance + 1 <= distance)
            {
                currentDistances.Add(rightDistance + 1);
            }
        }

        return currentDistances;
    }
}