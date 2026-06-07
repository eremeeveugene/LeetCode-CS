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

using LeetCode.Algorithms.KeepMultiplyingFoundValuesByTwo;

namespace LeetCode.Tests.Algorithms.KeepMultiplyingFoundValuesByTwo;

public abstract class KeepMultiplyingFoundValuesByTwoTestsBase<T> where T : IKeepMultiplyingFoundValuesByTwo, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 6, 1, 12 }, 3, 24)]
    [DataRow(new[] { 2, 7, 9 }, 4, 4)]
    [DataRow(new[] { 1000 }, 1000, 2000)]
    [DataRow(new[] { 1 }, 1, 2)]
    [DataRow(new[] { 1 }, 2, 2)]
    [DataRow(new[] { 1, 2, 4, 8 }, 1, 16)]
    [DataRow(new[] { 1, 2, 4, 8 }, 2, 16)]
    [DataRow(new[] { 1, 2, 4, 8 }, 8, 16)]
    [DataRow(new[] { 1, 2, 4, 8 }, 16, 16)]
    [DataRow(new[] { 1, 2, 4, 8 }, 3, 3)]
    [DataRow(new[] { 5 }, 5, 10)]
    [DataRow(new[] { 5, 10 }, 5, 20)]
    [DataRow(new[] { 5, 10, 20 }, 5, 40)]
    [DataRow(new[] { 5, 10, 20, 40 }, 5, 80)]
    [DataRow(new[] { 5, 10, 20, 40, 80 }, 5, 160)]
    [DataRow(new[] { 5, 10, 20, 40, 80, 160 }, 5, 320)]
    [DataRow(new[] { 5, 10, 20, 40, 80, 160, 320 }, 5, 640)]
    [DataRow(new[] { 5, 10, 20, 40, 80, 160, 320, 640 }, 5, 1280)]
    [DataRow(new[] { 1000 }, 500, 500)]
    [DataRow(new[] { 999, 1000 }, 999, 1998)]
    public void FindFinalValue_WithNumsArrayAndOriginalValue_ReturnsFinalMultipliedValue(int[] nums, int original, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindFinalValue(nums, original);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}