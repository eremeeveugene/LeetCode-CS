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

using LeetCode.Algorithms.ConstructUniformParityArray2;

namespace LeetCode.Tests.Algorithms.ConstructUniformParityArray2;

public abstract class ConstructUniformParityArray2TestsBase<T> where T : IConstructUniformParityArray2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 7 }, true)]
    [DataRow(new[] { 2, 3 }, false)]
    [DataRow(new[] { 4, 6 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 2, 4 }, true)]
    [DataRow(new[] { 2, 5 }, false)]
    [DataRow(new[] { 2, 3, 5 }, false)]
    [DataRow(new[] { 1, 3, 5, 7 }, true)]
    [DataRow(new[] { 2, 4, 6, 8 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 2, 4, 6, 1 }, true)]
    [DataRow(new[] { 10, 20, 3 }, true)]
    [DataRow(new[] { 10, 20, 30, 15 }, false)]
    [DataRow(new[] { 1000000000, 999999999 }, true)]
    [DataRow(new[] { 1000000000, 2 }, true)]
    [DataRow(new[] { 1, 1000000000 }, true)]
    [DataRow(new[] { 4, 6, 8, 10, 12 }, true)]
    [DataRow(new[] { 3, 5, 7, 9, 11 }, true)]
    [DataRow(new[] { 2, 4, 8, 16, 5 }, false)]
    [DataRow(new[] { 6, 4, 2, 8, 10, 12 }, true)]
    [DataRow(new[] { 7, 1, 3, 5, 9 }, true)]
    [DataRow(new[] { 100, 200, 99 }, true)]
    [DataRow(new[] { 100, 200, 50 }, true)]
    public void UniformArray_WithDistinctIntegerArray_ReturnsTrueIfUniformParityArrayCanBeConstructed(int[] nums1, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniformArray(nums1);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}