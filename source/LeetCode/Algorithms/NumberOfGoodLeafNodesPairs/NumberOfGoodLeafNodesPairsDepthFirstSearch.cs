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

namespace LeetCode.Algorithms.NumberOfGoodLeafNodesPairs;

/// <inheritdoc />
public sealed class NumberOfGoodLeafNodesPairsDepthFirstSearch : INumberOfGoodLeafNodesPairs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * d^2)
    ///     Space complexity - O(n * d)
    /// </remarks>
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

        result += CountGoodPairs(leftDistances, rightDistances, distance);

        var currentDistances = new List<int>();

        AddIncrementedDistances(leftDistances, distance, currentDistances);
        AddIncrementedDistances(rightDistances, distance, currentDistances);

        return currentDistances;
    }

    private static int CountGoodPairs(List<int> leftDistances, List<int> rightDistances, int distance)
    {
        var count = 0;

        for (var i = 0; i < leftDistances.Count; i++)
        {
            var leftDistance = leftDistances[i];

            for (var j = 0; j < rightDistances.Count; j++)
            {
                var rightDistance = rightDistances[j];

                if (leftDistance + rightDistance <= distance)
                {
                    count++;
                }
            }
        }

        return count;
    }

    private static void AddIncrementedDistances(List<int> childDistances, int distance, List<int> currentDistances)
    {
        for (var i = 0; i < childDistances.Count; i++)
        {
            var childDistance = childDistances[i];

            if (childDistance + 1 <= distance)
            {
                currentDistances.Add(childDistance + 1);
            }
        }
    }
}