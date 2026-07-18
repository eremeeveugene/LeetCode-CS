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

using LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

namespace LeetCode.Tests.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

public abstract class MaximumCountOfPositiveIntegerAndNegativeIntegerTestsBase<T> where T : IMaximumCountOfPositiveIntegerAndNegativeInteger, new()
{
    [TestMethod]
    [DataRow(new[] { -2, -1, -1, 1, 2, 3 }, 3)]
    [DataRow(new[] { -3, -2, -1, 0, 0, 1, 2 }, 3)]
    [DataRow(new[] { 5, 20, 66, 1314 }, 4)]
    [DataRow(new int[] { }, 0)]
    [DataRow(new[] { -3, -2, -1 }, 3)]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, 5)]
    [DataRow(new[] { -1, 0 }, 1)]
    [DataRow(new[] { -2, -2, 0, 0 }, 2)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { -5 }, 1)]
    [DataRow(new[] { 7 }, 1)]
    [DataRow(new[] { -1, 1 }, 1)]
    [DataRow(new[] { 0, 1, 2 }, 2)]
    [DataRow(new[] { 0, 0, 1 }, 1)]
    [DataRow(new[] { -2, -1, 0 }, 2)]
    [DataRow(new[] { -1, 0, 1 }, 1)]
    [DataRow(new[] { -3, -2, -1, 1, 2 }, 3)]
    [DataRow(new[] { -1, -1, 0, 0, 1 }, 2)]
    [DataRow(new[] { -1, 0, 0, 0, 1, 1 }, 2)]
    [DataRow(new[] { -1000, -5, 0, 5, 1000 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { -1, -1, -1, 1 }, 3)]
    public void MaximumCount_GivenIntegerArray_ReturnsCountOfMaxPositiveOrNegativeNumbers(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumCount(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}