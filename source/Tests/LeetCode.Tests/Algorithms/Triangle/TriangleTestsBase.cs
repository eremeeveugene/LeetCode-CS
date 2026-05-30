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

using LeetCode.Algorithms.Triangle;

namespace LeetCode.Tests.Algorithms.Triangle;

public abstract class TriangleTestsBase<T> where T : ITriangle, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumTotal_WithTriangleInput_ReturnsMinimumPathSumFromTopToBottom(IList<IList<int>> triangle, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumTotal(triangle);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new IList<int>[] { new[] { 2 }, new[] { 3, 4 }, new[] { 6, 5, 7 }, new[] { 4, 1, 8, 3 } }, 11];

        yield return [new IList<int>[] { new[] { -10 } }, -10];
    }
}