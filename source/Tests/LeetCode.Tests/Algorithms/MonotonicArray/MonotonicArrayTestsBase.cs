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