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

namespace LeetCode.Algorithms.OpenTheLock;

/// <inheritdoc />
public class OpenTheLockBreadthFirstSearch : IOpenTheLock
{
    private const string Start = "0000";

    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="deadends"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int OpenLock(string[] deadends, string target)
    {
        var deadendsHashSet = new HashSet<string>(deadends);
        var visitedHashSet = new HashSet<string> { Start };
        var queue = new Queue<(string, int)>();

        queue.Enqueue((Start, 0));

        if (deadendsHashSet.Contains(Start))
        {
            return -1;
        }

        while (queue.Count > 0)
        {
            var (state, steps) = queue.Dequeue();

            if (state == target)
            {
                return steps;
            }

            for (var i = 0; i < state.Length; i++)
            {
                var digit = char.GetNumericValue(state[i]);

                foreach (var move in new[] { -1, 1 })
                {
                    var newDigit = (digit + move + 10) % 10;
                    var newState = state[..i] + newDigit + state[(i + 1)..];

                    if (visitedHashSet.Contains(newState) || deadendsHashSet.Contains(newState))
                    {
                        continue;
                    }

                    visitedHashSet.Add(newState);
                    queue.Enqueue((newState, steps + 1));
                }
            }
        }

        return -1;
    }
}