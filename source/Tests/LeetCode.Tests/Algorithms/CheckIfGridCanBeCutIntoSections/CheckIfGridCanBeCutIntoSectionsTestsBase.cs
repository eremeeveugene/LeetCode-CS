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

using LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;

namespace LeetCode.Tests.Algorithms.CheckIfGridCanBeCutIntoSections;

public abstract class CheckIfGridCanBeCutIntoSectionsTestsBase<T> where T : ICheckIfGridCanBeCutIntoSections, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CheckValidCuts_WithGridSizeAndRectangles_ReturnsWhetherGridCanBeCutIntoSections(int n,
        int[][] rectangles, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckValidCuts(n, rectangles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 1, 0, 5, 2 }, new[] { 0, 2, 2, 4 }, new[] { 3, 2, 5, 3 }, new[] { 0, 4, 4, 5 } }, true];

        yield return [4, new[] { new[] { 0, 0, 1, 1 }, new[] { 2, 0, 3, 4 }, new[] { 0, 2, 2, 3 }, new[] { 3, 0, 4, 3 } }, true];

        yield return [4, new[] { new[] { 0, 2, 2, 4 }, new[] { 1, 0, 3, 2 }, new[] { 2, 2, 3, 4 }, new[] { 3, 0, 4, 2 }, new[] { 3, 2, 4, 4 } }, false];
    }
}