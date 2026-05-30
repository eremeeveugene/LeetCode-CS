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

using LeetCode.Algorithms.FindCenterOfStarGraph;

namespace LeetCode.Tests.Algorithms.FindCenterOfStarGraph;

public abstract class FindCenterOfStarGraphTestsBase<T> where T : IFindCenterOfStarGraph, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindCenter_GivenEdgesJson_ReturnsCenterNode(int[][] edges, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindCenter(edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 4, 2 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 5, 1 }, new[] { 1, 3 }, new[] { 1, 4 } }, 1];
    }
}