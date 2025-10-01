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

namespace LeetCode.Algorithms.ValidArrangementOfPairs;

/// <inheritdoc />
public class ValidArrangementOfPairsDepthFirstSearch : IValidArrangementOfPairs
{
    /// <summary>
    ///     Time complexity - O(E + V), where E is the number of edges (pairs) and V is the number of vertices (unique nodes)
    ///     Space complexity - O(E + V), where E is the number of edges (pairs) and V is the number of vertices (unique nodes)
    /// </summary>
    /// <param name="pairs"></param>
    /// <returns></returns>
    public int[][] ValidArrangement(int[][] pairs)
    {
        var startToEndsDictionary = new Dictionary<int, Stack<int>>();
        var endToCountDictionary = new Dictionary<int, int>();
        var startToCountDictionary = new Dictionary<int, int>();

        var pairsLength = pairs.Length;

        for (var i = 0; i < pairsLength; i++)
        {
            var pair = pairs[i];
            var start = pair[0];
            var end = pair[1];

            if (!startToEndsDictionary.TryGetValue(start, out var ends))
            {
                ends = new Stack<int>();

                startToEndsDictionary[start] = ends;
            }

            ends.Push(end);

            startToCountDictionary[start] = startToCountDictionary.GetValueOrDefault(start) + 1;
            endToCountDictionary[end] = endToCountDictionary.GetValueOrDefault(end) + 1;
        }

        var startNode = FindStartNode(startToCountDictionary, endToCountDictionary, pairs);

        var pairsIndex = pairsLength - 1;

        BuildEulerianPath(startToEndsDictionary, pairs, startNode, ref pairsIndex);

        return pairs;
    }

    private static int FindStartNode(Dictionary<int, int> startToCountDictionary,
        Dictionary<int, int> endToCountDictionary, int[][] pairs)
    {
        var startNode = pairs[0][0];

        foreach (var (start, startCount) in startToCountDictionary)
        {
            var endCount = endToCountDictionary.GetValueOrDefault(start);

            if (startCount > endCount)
            {
                return start;
            }
        }

        return startNode;
    }

    private static void BuildEulerianPath(Dictionary<int, Stack<int>> startToEndsDictionary, int[][] pairs, int start,
        ref int pairsIndex)
    {
        if (!startToEndsDictionary.TryGetValue(start, out var ends))
        {
            return;
        }

        while (ends.Count > 0)
        {
            var end = ends.Pop();

            BuildEulerianPath(startToEndsDictionary, pairs, end, ref pairsIndex);

            var pair = pairs[pairsIndex];

            pair[0] = start;
            pair[1] = end;

            pairsIndex--;
        }
    }
}