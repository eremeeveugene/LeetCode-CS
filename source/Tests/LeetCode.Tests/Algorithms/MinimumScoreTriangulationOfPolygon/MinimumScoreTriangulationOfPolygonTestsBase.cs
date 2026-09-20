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

using LeetCode.Algorithms.MinimumScoreTriangulationOfPolygon;

namespace LeetCode.Tests.Algorithms.MinimumScoreTriangulationOfPolygon;

public abstract class MinimumScoreTriangulationOfPolygonTestsBase<T> where T : IMinimumScoreTriangulationOfPolygon, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 6)]
    [DataRow(new[] { 3, 7, 4, 5 }, 144)]
    [DataRow(new[] { 1, 3, 1, 4, 1, 5 }, 13)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 100, 100, 100 }, 1000000)]
    [DataRow(new[] { 1, 100, 100 }, 10000)]
    [DataRow(new[] { 2, 3, 4 }, 24)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2, 2 }, 16)]
    [DataRow(new[] { 1, 2, 3, 4 }, 18)]
    [DataRow(new[] { 4, 3, 2, 1 }, 18)]
    [DataRow(new[] { 1, 100, 1, 100 }, 200)]
    [DataRow(new[] { 100, 1, 100, 1 }, 200)]
    [DataRow(new[] { 100, 100, 100, 100 }, 2000000)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3)]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 24)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 38)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 38)]
    [DataRow(new[] { 2, 7, 3, 8, 4 }, 154)]
    [DataRow(new[] { 1, 10, 1, 10, 1 }, 21)]
    [DataRow(new[] { 5, 1, 5, 1, 5, 1 }, 16)]
    [DataRow(new[] { 2, 3, 4, 5, 6, 7 }, 208)]
    [DataRow(new[] { 7, 4, 5, 3 }, 144)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2 }, 75)]
    [DataRow(new[] { 1, 100, 100, 100, 1 }, 20100)]
    [DataRow(
        new[]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        },
        48)]
    [DataRow(
        new[]
        {
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100
        },
        48000000)]
    public void MinScoreTriangulation_WithGivenVertexValues_ReturnsMinimumScore(int[] values, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinScoreTriangulation(values);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}