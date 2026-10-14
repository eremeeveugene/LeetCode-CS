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

using LeetCode.Algorithms.MonotonicArray;

namespace LeetCode.Tests.Algorithms.MonotonicArray;

public abstract class MonotonicArrayTestsBase<T> where T : IMonotonicArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 3 }, true)]
    [DataRow(new[] { 6, 5, 4, 4 }, true)]
    [DataRow(new[] { 1, 3, 2 }, false)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 1, 1, 1 }, true)]
    [DataRow(new[] { 3, 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 3, 1, 2 }, false)]
    [DataRow(new[] { 2, 1, 3 }, false)]
    [DataRow(new[] { 1, 1, 2, 2, 1 }, false)]
    [DataRow(new[] { -1, -2, -2, -3 }, true)]
    [DataRow(new[] { -5, 0, 5 }, true)]
    [DataRow(new[] { 5, 5, 5, 4 }, true)]
    [DataRow(new[] { 1, 2, 1, 2 }, false)]
    [DataRow(new[] { 100000, -100000 }, true)]
    [DataRow(new[] { -100000, 100000 }, true)]
    [DataRow(new[] { 0, 0 }, true)]
    [DataRow(new[] { 1, 3, 3, 2 }, false)]
    [DataRow(new[] { 1, 2, 3, 3, 2 }, false)]
    [DataRow(new[] { 10, 9, 8, 8, 9 }, false)]
    [DataRow(new[] { 1, 1, 1, 2 }, true)]
    [DataRow(new[] { 2, 1, 1, 1 }, true)]
    public void IsMonotonic_WithIntegerArray_ReturnsTrueIfArrayIsMonotonic(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsMonotonic(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}