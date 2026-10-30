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

using LeetCode.Algorithms.ShortestPathWithAtMostKConsecutiveIdenticalCharacters;

namespace LeetCode.Tests.Algorithms.ShortestPathWithAtMostKConsecutiveIdenticalCharacters;

public abstract class ShortestPathWithAtMostKConsecutiveIdenticalCharactersTestsBase<T>
    where T : IShortestPathWithAtMostKConsecutiveIdenticalCharacters, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShortestPath_WithNodesEdgesLabelsAndK_ReturnsMinimumTotalWeight(int n, int[][] edges, string labels, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShortestPath(n, edges, labels, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 0, 2, 3 } }, "aab", 1, 3];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 0, 2, 3 } }, "aab", 2, 2];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "aaa", 2, -1];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "aaa", 3, 2];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "aba", 1, 2];

        yield return [1, Array.Empty<int[]>(), "a", 1, 0];

        yield return [2, Array.Empty<int[]>(), "ab", 1, -1];

        yield return [2, new[] { new[] { 0, 1, 5 } }, "ab", 1, 5];

        yield return [2, new[] { new[] { 0, 1, 5 } }, "aa", 1, -1];

        yield return [2, new[] { new[] { 0, 1, 5 } }, "aa", 2, 5];

        yield return [2, new[] { new[] { 1, 0, 5 } }, "ab", 1, -1];

        yield return [2, new[] { new[] { 0, 1, 3 }, new[] { 1, 0, 1 } }, "ab", 1, 3];

        yield return [2, new[] { new[] { 0, 1, 7 }, new[] { 0, 1, 2 } }, "ab", 1, 2];

        yield return [3, new[] { new[] { 0, 2, 1 }, new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "aba", 1, 2];

        yield return [3, new[] { new[] { 0, 2, 1 }, new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "aba", 2, 1];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 3, 1 }, new[] { 0, 2, 2 }, new[] { 2, 3, 2 } }, "aabb", 1, -1];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 3, 1 }, new[] { 0, 2, 2 }, new[] { 2, 3, 2 } }, "aabb", 2, 2];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 3, 1 }, new[] { 0, 2, 2 }, new[] { 2, 3, 2 } }, "aacb", 1, 4];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 3, 1 }, new[] { 0, 2, 10 }, new[] { 2, 1, 1 } }, "aaba", 2, 12];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 3, 1 }, new[] { 0, 2, 10 }, new[] { 2, 1, 1 } }, "aaba", 3, 2];

        yield return [4, new[] { new[] { 0, 2, 1 }, new[] { 2, 3, 1 }, new[] { 2, 1, 1 }, new[] { 1, 2, 1 } }, "abaa", 2, 4];

        yield return [4, new[] { new[] { 0, 2, 1 }, new[] { 2, 3, 1 }, new[] { 2, 1, 1 }, new[] { 1, 2, 1 } }, "abaa", 3, 2];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, "abcd", 1, -1];

        yield return [5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, "ababa", 1, 4];

        yield return [5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, "aabba", 1, -1];

        yield return [5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, "aabba", 2, 4];

        yield return [4, new[] { new[] { 0, 1, 5 }, new[] { 0, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 3, 10 } }, "abcd", 1, 12];

        yield return
        [
            5,
            new[] { new[] { 0, 1, 4 }, new[] { 0, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 4, 1 }, new[] { 2, 3, 5 }, new[] { 3, 4, 1 } },
            "abcde",
            1,
            3
        ];

        yield return [50, CreateChainEdges(50), new string('a', 50), 50, 49];

        yield return [51, CreateChainEdges(51), new string('a', 51), 50, -1];

        yield return [50000, CreateChainEdges(50000), CreateAlternatingLabels(50000), 1, 49999];
    }

    private static int[][] CreateChainEdges(int nodes)
    {
        var edges = new int[nodes - 1][];

        for (var i = 0; i < nodes - 1; i++)
        {
            edges[i] = [i, i + 1, 1];
        }

        return edges;
    }

    private static string CreateAlternatingLabels(int nodes)
    {
        var labels = new char[nodes];

        for (var i = 0; i < nodes; i++)
        {
            labels[i] = i % 2 == 0 ? 'a' : 'b';
        }

        return new string(labels);
    }
}