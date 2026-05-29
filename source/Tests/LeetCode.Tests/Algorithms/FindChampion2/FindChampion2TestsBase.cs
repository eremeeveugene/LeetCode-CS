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

using LeetCode.Algorithms.FindChampion2;

namespace LeetCode.Tests.Algorithms.FindChampion2;

public abstract class FindChampion2TestsBase<T> where T : IFindChampion2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindChampion_WithNodeCountAndDirectedEdges_ReturnsChampionOrMinusOne(int n, int[][] edges,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindChampion(n, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [1, Array.Empty<int[]>(), 0];

        yield return [2, Array.Empty<int[]>(), -1];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 0];

        yield return [4, new[] { new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 2 } }, -1];
    }
}