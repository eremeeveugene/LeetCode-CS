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

using LeetCode.Algorithms.MajorityElement;

namespace LeetCode.Tests.Algorithms.MajorityElement;

public abstract class MajorityElementTestsBase<T> where T : IMajorityElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 3 }, 3)]
    [DataRow(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 5, 5 }, 5)]
    [DataRow(new[] { 1, 1, 2 }, 1)]
    [DataRow(new[] { -1, -1, 2 }, -1)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 7, 7, 7, 7 }, 7)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 1)]
    [DataRow(new[] { 4, 4, 4, 1, 2 }, 4)]
    [DataRow(new[] { 9, 8, 9, 8, 9 }, 9)]
    [DataRow(new[] { -5, -5, -5, 3, 3 }, -5)]
    [DataRow(new[] { 1000000000, 1000000000, -1000000000 }, 1000000000)]
    [DataRow(new[] { -1000000000, -1000000000, 1000000000 }, -1000000000)]
    [DataRow(new[] { 6, 6, 6, 6, 1, 2, 3 }, 6)]
    [DataRow(new[] { 2, 1, 2, 1, 2, 1, 2 }, 2)]
    [DataRow(new[] { 3, 3, 4, 2, 4, 4, 2, 4, 4 }, 4)]
    [DataRow(new[] { 10, 9, 9, 9, 10, 9, 9 }, 9)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 2, 2, 2, 3, 3 }, 2)]
    [DataRow(new[] { -7, -7, 1, -7, 2 }, -7)]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, 0)]
    [DataRow(new[] { 8, 8, 8, 8, 8, 1, 2, 3, 4 }, 8)]
    public void MajorityElement_WithIntegerArray_ReturnsMajorityElement(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MajorityElement(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}