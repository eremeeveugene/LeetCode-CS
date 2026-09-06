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

using LeetCode.Algorithms.CountIntegersAppearingInASingleBlock;

namespace LeetCode.Tests.Algorithms.CountIntegersAppearingInASingleBlock;

public abstract class CountIntegersAppearingInASingleBlockTestsBase<T> where T : ICountIntegersAppearingInASingleBlock, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 1 }, 1)]
    [DataRow(new[] { 3, 3, 1, 2, 2, 1 }, 2)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 2, 2, 2, 2 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 3)]
    [DataRow(new[] { 1, 2, 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1, 3, 1 }, 2)]
    [DataRow(new[] { 1, 1, 2, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 2, 2, 4 }, 3)]
    [DataRow(new[] { 100, 100, 1, 1 }, 2)]
    [DataRow(new[] { 100, 1, 100 }, 1)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 100 }, 2)]
    [DataRow(new[] { 100, 99, 98, 97, 96 }, 5)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 0)]
    [DataRow(new[] { 1, 1, 2, 2, 1, 1, 2, 2 }, 0)]
    [DataRow(new[] { 1, 2, 1, 3, 3 }, 2)]
    [DataRow(new[] { 3, 3, 1, 2, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 3, 2, 4, 4, 1 }, 2)]
    [DataRow(new[] { 100, 1, 100, 1, 100, 50, 50 }, 1)]
    [DataRow(new[] { 1, 1, 2, 3, 3, 4, 5, 5, 6 }, 6)]
    [DataRow(new[] { 5, 5, 1, 1, 5, 5, 2, 2, 5, 5 }, 2)]
    public void CountSpecialIntegers_WithGivenArray_ReturnsNumberOfDistinctIntegersInSingleBlock(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSpecialIntegers(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}