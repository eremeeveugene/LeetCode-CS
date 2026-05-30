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

using LeetCode.Algorithms.CheckIfItIsStraightLine;

namespace LeetCode.Tests.Algorithms.CheckIfItIsStraightLine;

public abstract class CheckIfItIsStraightLineTestsBase<T> where T : ICheckIfItIsStraightLine, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CheckStraightLine_WithGivenCoordinates_ReturnsIfPointsFormStraightLine(int[][] coordinates, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckStraightLine(coordinates);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 2, 4 }, new[] { 3, 3 } }, false];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 } }, true];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 7, 7 } }, false];
    }
}