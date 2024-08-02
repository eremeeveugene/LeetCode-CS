// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumSwapsToGroupAll1Together2;

namespace LeetCode.Tests.Algorithms.MinimumSwapsToGroupAll1Together2;

public abstract class MinimumSwapsToGroupAll1Together2TestBase<T> where T : IMinimumSwapsToGroupAll1Together2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 0, 0, 1 }, 0)]
    [DataRow(new[] { 0, 1, 0, 1, 1, 0, 0 }, 1)]
    [DataRow(new[] { 0, 1, 1, 1, 0, 0, 1, 1, 0 }, 2)]
    public void MinSwaps_WithBinaryArray_ReturnsMinimumSwapsToGroupOnes(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSwaps(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}