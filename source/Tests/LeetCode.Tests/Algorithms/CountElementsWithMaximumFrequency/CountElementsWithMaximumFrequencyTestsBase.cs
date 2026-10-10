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

using LeetCode.Algorithms.CountElementsWithMaximumFrequency;

namespace LeetCode.Tests.Algorithms.CountElementsWithMaximumFrequency;

public abstract class CountElementsWithMaximumFrequencyTestsBase<T> where T : ICountElementsWithMaximumFrequency, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 3, 1, 4 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 7, 7, 7 }, 3)]
    [DataRow(new[] { 1, 1, 2, 2 }, 4)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 6)]
    [DataRow(new[] { 5, 5, 5, 6, 6, 7 }, 3)]
    [DataRow(new[] { 100, 100, 99, 99, 98 }, 4)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3 }, 6)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 3)]
    [DataRow(new[] { 4, 4, 5, 5, 6, 6, 7 }, 6)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 10)]
    [DataRow(new[] { 2, 2, 2, 9, 9, 9, 9, 1 }, 4)]
    [DataRow(new[] { 50, 50, 50, 50, 1, 1, 1, 1, 2, 2, 2, 2, 3 }, 12)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 }, 2)]
    [DataRow(new[] { 9, 8, 7, 7, 8, 9 }, 6)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 100)]
    public void MaxFrequencyElements_GivenArray_ReturnsMaximumElementFrequency(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFrequencyElements(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}