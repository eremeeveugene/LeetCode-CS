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

using LeetCode.Algorithms.ThirdMaximumNumber;

namespace LeetCode.Tests.Algorithms.ThirdMaximumNumber;

public abstract class ThirdMaximumNumberTestsBase<T> where T : IThirdMaximumNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 1, 1, 2 }, 2)]
    [DataRow(new[] { 2, 2, 3, 1 }, 1)]
    [DataRow(new[] { 14 }, 14)]
    [DataRow(new[] { 1, 2, -2147483648 }, int.MinValue)]
    [DataRow(new[] { 1, -2147483648, 2 }, int.MinValue)]
    [DataRow(new[] { 5, 4, 3, 2 }, 3)]
    [DataRow(new[] { 5, 4, 1, 3 }, 3)]
    [DataRow(new[] { 4, 3, 2, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow(new[] { 10, 5, 7, 3 }, 5)]
    [DataRow(new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 1, 2, 2, 3 }, 1)]
    [DataRow(new[] { 2, 3, 1 }, 1)]
    [DataRow(new[] { 5, 5, 4, 3 }, 3)]
    [DataRow(new[] { 100, 90, 80, 70 }, 80)]
    [DataRow(new[] { -1, -2, -3 }, -3)]
    [DataRow(new[] { 0, -1, -2 }, -2)]
    public void ThirdMax_WithIntArray_ReturnsThirdMaximumOrMaximum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThirdMax(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}