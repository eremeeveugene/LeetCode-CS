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

using LeetCode.Algorithms.MakeArrayElementsEqualToZero;

namespace LeetCode.Tests.Algorithms.MakeArrayElementsEqualToZero;

public abstract class MakeArrayElementsEqualToZeroTestsBase<T> where T : IMakeArrayElementsEqualToZero, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 2, 0, 3 }, 2)]
    [DataRow(new[] { 2, 3, 4, 0, 4, 1, 0 }, 0)]
    [DataRow(new[] { 0 }, 2)]
    [DataRow(new[] { 0, 0 }, 4)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { 1, 0 }, 1)]
    [DataRow(new[] { 0, 5, 0 }, 0)]
    [DataRow(new[] { 1, 0, 1 }, 2)]
    [DataRow(new[] { 2, 0, 2 }, 2)]
    [DataRow(new[] { 0, 0, 0, 0 }, 8)]
    [DataRow(new[] { 1, 1, 0, 1, 1 }, 2)]
    [DataRow(new[] { 3, 0, 0, 3 }, 4)]
    [DataRow(new[] { 0, 2, 1, 1 }, 0)]
    [DataRow(new[] { 100, 0 }, 0)]
    [DataRow(new[] { 0, 100 }, 0)]
    [DataRow(new[] { 100, 0, 100 }, 2)]
    [DataRow(new[] { 1, 2, 3, 0, 3, 2, 1 }, 2)]
    [DataRow(new[] { 0, 1, 2, 0, 2, 1, 0 }, 2)]
    [DataRow(new[] { 2, 3, 1, 0, 0, 0, 0, 1, 1 }, 0)]
    [DataRow(new[] { 1, 3, 3, 1, 1, 0, 2, 3, 2, 1 }, 1)]
    [DataRow(new[] { 0, 1, 2, 3, 1 }, 0)]
    [DataRow(new[] { 0, 3, 1, 1, 1, 3, 2, 1, 0, 2 }, 0)]
    [DataRow(new[] { 1, 2, 0, 0, 3, 0, 2, 1, 3 }, 2)]
    public void CountValidSelections_WithNumsArray_ReturnsNumberOfValidStartPositions(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountValidSelections(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}