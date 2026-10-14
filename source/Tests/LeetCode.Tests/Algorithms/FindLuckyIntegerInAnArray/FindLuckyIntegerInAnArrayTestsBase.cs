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

using LeetCode.Algorithms.FindLuckyIntegerInAnArray;

namespace LeetCode.Tests.Algorithms.FindLuckyIntegerInAnArray;

public abstract class FindLuckyIntegerInAnArrayTestsBase<T> where T : IFindLuckyIntegerInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 3)]
    [DataRow(new[] { 2, 2, 2, 3, 3 }, -1)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2 }, -1)]
    [DataRow(new[] { 1, 1 }, -1)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 4)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7 }, 7)]
    [DataRow(new[] { 500 }, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 2, 2, 1, 3, 3, 3 }, 3)]
    [DataRow(new[] { 4, 4, 4, 4, 1, 2, 2 }, 4)]
    [DataRow(new[] { 3, 1, 1, 5, 3, 4, 4, 5, 3, 2, 2, 3, 4, 1, 2 }, -1)]
    [DataRow(new[] { 4, 1, 1, 1, 4, 4, 1, 5, 4, 3 }, 4)]
    [DataRow(new[] { 1, 2, 1, 5, 3, 2, 5, 2, 3, 5, 3, 5, 3 }, -1)]
    [DataRow(new[] { 3, 5, 1, 4, 2, 4, 5, 4, 2, 2, 2 }, 1)]
    [DataRow(new[] { 3, 5, 2, 5, 1, 1, 1, 4, 1 }, -1)]
    [DataRow(new[] { 3, 5, 3, 5, 3, 1, 3, 3, 5, 3 }, 1)]
    [DataRow(new[] { 4, 5, 2, 3, 2, 1, 5, 1, 4, 2, 3, 5, 2, 5, 1 }, -1)]
    [DataRow(new[] { 2, 4, 1, 1, 4, 4, 1 }, -1)]
    public void FindLucky_WithIntegersArray_ReturnsLargestLuckyIntegerOrMinusOne(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLucky(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}