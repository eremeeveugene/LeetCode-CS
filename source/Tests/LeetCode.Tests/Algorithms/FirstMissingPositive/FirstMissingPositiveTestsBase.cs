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

using LeetCode.Algorithms.FirstMissingPositive;

namespace LeetCode.Tests.Algorithms.FirstMissingPositive;

public abstract class FirstMissingPositiveTestsBase<T> where T : IFirstMissingPositive, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 1)]
    [DataRow(new[] { 1, 2, 0 }, 3)]
    [DataRow(new[] { 3, 4, -1, 1 }, 2)]
    [DataRow(new[] { 7, 8, 9, 11, 12 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 4)]
    [DataRow(new[] { -1, -2, -3 }, 1)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { 2, 3, 4 }, 1)]
    [DataRow(new[] { 1 }, 2)]
    [DataRow(new[] { 5, 3, 2, 1, 4 }, 6)]
    [DataRow(new[] { 0, 2, 2, 1, 1 }, 3)]
    [DataRow(new[] { 1, 1, 0, -1, -2 }, 2)]
    [DataRow(new[] { int.MaxValue }, 1)]
    [DataRow(new[] { int.MinValue }, 1)]
    [DataRow(new[] { 2, 1 }, 3)]
    [DataRow(new[] { 1000000000, -1000000000 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 12 }, 11)]
    [DataRow(new[] { 2, 2, 2 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 2)]
    [DataRow(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, 5)]
    [DataRow(new[] { int.MinValue, int.MaxValue, 1, 2 }, 3)]
    public void FirstMissingPositive_GivenArray_ReturnsFirstMissingPositiveInteger(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstMissingPositive(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}