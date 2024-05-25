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

namespace LeetCode.Algorithms.NaryTreeLevelOrderTraversal;

/// <inheritdoc />
public class NaryTreeLevelOrderTraversalBreadthFirstSearch : INaryTreeLevelOrderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<IList<int>> LevelOrder(Node? root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }

        var result = new List<IList<int>>();

        var currentLevelNodes = new Queue<Node>();

        currentLevelNodes.Enqueue(root);

        while (currentLevelNodes.Count > 0)
        {
            var levelValues = new List<int>();

            var nextLevelNodes = new Queue<Node>();

            while (currentLevelNodes.Count > 0)
            {
                var currentNode = currentLevelNodes.Dequeue();

                levelValues.Add(currentNode.val);

                if (currentNode.children == null)
                {
                    continue;
                }

                foreach (var child in currentNode.children)
                {
                    nextLevelNodes.Enqueue(child);
                }
            }

            result.Add(levelValues);

            currentLevelNodes = nextLevelNodes;
        }

        return result;
    }
}