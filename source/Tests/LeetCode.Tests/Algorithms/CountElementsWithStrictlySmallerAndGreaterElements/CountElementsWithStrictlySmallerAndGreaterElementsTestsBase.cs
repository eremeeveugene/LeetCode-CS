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

using LeetCode.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;

namespace LeetCode.Tests.Algorithms.CountElementsWithStrictlySmallerAndGreaterElements;

public abstract class CountElementsWithStrictlySmallerAndGreaterElementsTestsBase<T> where T : ICountElementsWithStrictlySmallerAndGreaterElements, new()
{
    [TestMethod]
    [DataRow(new[] { 11, 7, 2, 15 }, 2)]
    [DataRow(new[] { -3, 3, 3, 90 }, 2)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 1)]
    [DataRow(new[] { 1, 2, 2, 3 }, 2)]
    [DataRow(new[] { -10, 0, 10 }, 1)]
    [DataRow(new[] { -5, -3, -1 }, 1)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 100 }, 0)]
    [DataRow(new[] { 1, 3, 3, 3, 5 }, 3)]
    [DataRow(new[] { -100, 0, 100 }, 1)]
    [DataRow(new[] { 1, 2, 3, 3, 4 }, 3)]
    [DataRow(new[] { 10, 20, 30, 40 }, 2)]
    [DataRow(new[] { 2, 2, 3, 4 }, 1)]
    [DataRow(new[] { 1, 3, 4, 4 }, 1)]
    public void CountElements_GivenArray_ReturnsCountOfElementsMatchingCriteria(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountElements(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}