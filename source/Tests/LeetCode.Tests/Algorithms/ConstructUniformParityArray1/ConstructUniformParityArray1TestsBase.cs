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

using LeetCode.Algorithms.ConstructUniformParityArray1;

namespace LeetCode.Tests.Algorithms.ConstructUniformParityArray1;

public abstract class ConstructUniformParityArray1TestsBase<T> where T : IConstructUniformParityArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3 }, true)]
    [DataRow(new[] { 4, 6 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 1, 3 }, true)]
    [DataRow(new[] { 5, 10, 15 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 7, 9, 11 }, true)]
    [DataRow(new[] { 2, 4, 6, 8 }, true)]
    [DataRow(new[] { 100, 99 }, true)]
    [DataRow(new[] { 3, 8, 13, 18, 23 }, true)]
    [DataRow(new[] { 10, 20, 30 }, true)]
    [DataRow(new[] { 1, 100 }, true)]
    [DataRow(new[] { 11, 12, 13, 14, 15, 16 }, true)]
    [DataRow(new[] { 99, 97, 95 }, true)]
    [DataRow(new[] { 6, 9 }, true)]
    [DataRow(new[] { 50, 51, 52 }, true)]
    [DataRow(new[] { 21, 42, 63, 84 }, true)]
    [DataRow(new[] { 8, 1 }, true)]
    public void UniformArray_WithDistinctIntegerArray_ReturnsTrueIfUniformParityArrayCanBeConstructed(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniformArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}