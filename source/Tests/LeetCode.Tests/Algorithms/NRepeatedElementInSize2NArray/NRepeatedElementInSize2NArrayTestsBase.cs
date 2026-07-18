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

using LeetCode.Algorithms.NRepeatedElementInSize2NArray;

namespace LeetCode.Tests.Algorithms.NRepeatedElementInSize2NArray;

public abstract class NRepeatedElementInSize2NArrayTestsBase<T> where T : INRepeatedElementInSize2NArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 3 }, 3)]
    [DataRow(new[] { 2, 1, 2, 5, 3, 2 }, 2)]
    [DataRow(new[] { 5, 1, 5, 2, 5, 3, 5, 4 }, 5)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 4, 4 }, 4)]
    [DataRow(new[] { 1, 1, 2, 3 }, 1)]
    [DataRow(new[] { 3, 1, 3, 2 }, 3)]
    [DataRow(new[] { 7, 7, 7, 1, 7, 2 }, 7)]
    [DataRow(new[] { 9, 1, 9, 2, 9, 3, 9, 4 }, 9)]
    [DataRow(new[] { 10000, 1, 10000, 2 }, 10000)]
    [DataRow(new[] { 1, 2, 1, 3 }, 1)]
    [DataRow(new[] { 6, 1, 2, 6, 3, 6, 4, 6 }, 6)]
    [DataRow(new[] { 2, 2, 1, 3 }, 2)]
    [DataRow(new[] { 8, 3, 8, 1, 8, 2, 8, 4 }, 8)]
    [DataRow(new[] { 100, 200, 100, 300 }, 100)]
    [DataRow(new[] { 5, 5, 1, 2 }, 5)]
    [DataRow(new[] { 1, 3, 2, 3 }, 3)]
    [DataRow(new[] { 11, 12, 11, 13 }, 11)]
    [DataRow(new[] { 99, 1, 2, 99 }, 99)]
    [DataRow(new[] { 50, 50, 1, 2 }, 50)]
    [DataRow(new[] { 7, 8, 7, 9 }, 7)]
    [DataRow(new[] { 999, 999, 1, 2, 3, 4 }, 999)]
    [DataRow(new[] { 42, 1, 2, 42, 3, 42, 4, 42 }, 42)]
    public void RepeatedNTimes_WithArrayContainingOneElementRepeatedNTimes_ReturnsRepeatedElement(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RepeatedNTimes(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}