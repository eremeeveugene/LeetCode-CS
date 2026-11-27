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

using LeetCode.Algorithms.CountDominantElements;

namespace LeetCode.Tests.Algorithms.CountDominantElements;

public abstract class CountDominantElementsTestsBase<T> where T : ICountDominantElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 10, 2 }, 1)]
    [DataRow(new[] { 6, 4, 2 }, 2)]
    [DataRow(new[] { 7 }, 1)]
    [DataRow(new[] { 96, 75, 55 }, 1)]
    [DataRow(new[] { 5, 5 }, 2)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 3, 2, 1 }, 2)]
    [DataRow(new[] { 1, 3, 1 }, 1)]
    [DataRow(new[] { 3, 1, 3 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, 3)]
    [DataRow(new[] { 1, 100, 1, 100, 1 }, 2)]
    [DataRow(new[] { 1, 1, 2 }, 2)]
    [DataRow(new[] { 2, 1, 1 }, 2)]
    [DataRow(new[] { 1, 4, 2 }, 1)]
    [DataRow(new[] { 5, 4, 4, 5 }, 2)]
    [DataRow(new[] { 10, 20, 30, 20, 10 }, 3)]
    [DataRow(new[] { 1, 3, 4, 3, 1 }, 3)]
    [DataRow(new[] { 4, 3, 5 }, 2)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 6)]
    [DataRow(new[] { 50, 51, 53 }, 1)]
    [DataRow(new[] { 1, 2, 1, 2 }, 2)]
    public void CountDominantElements_WithInputNums_ReturnsNumberOfDominantElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountDominantElements(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}