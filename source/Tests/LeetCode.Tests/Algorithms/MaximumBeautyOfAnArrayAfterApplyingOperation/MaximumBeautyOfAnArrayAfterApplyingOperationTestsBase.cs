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

using LeetCode.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

namespace LeetCode.Tests.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

public abstract class MaximumBeautyOfAnArrayAfterApplyingOperationTestsBase<T> where T : IMaximumBeautyOfAnArrayAfterApplyingOperation, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 6, 1, 2 }, 2, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 10, 4)]
    [DataRow(new[] { 5 }, 0, 1)]
    [DataRow(new[] { 5 }, 5, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 3)]
    [DataRow(new[] { 10, 20, 30 }, 0, 1)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 3)]
    [DataRow(new[] { 0, 0, 0 }, 0, 3)]
    [DataRow(new[] { 1, 10 }, 4, 1)]
    [DataRow(new[] { 1, 10 }, 5, 2)]
    [DataRow(new[] { 2, 4, 6, 8 }, 1, 2)]
    [DataRow(new[] { 100, 200, 300 }, 50, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 3, 4)]
    [DataRow(new[] { 1, 5, 9, 13 }, 2, 2)]
    [DataRow(new[] { 3, 6, 9, 12, 15 }, 3, 3)]
    [DataRow(new[] { 1, 2 }, 1, 2)]
    [DataRow(new[] { 1, 100 }, 50, 2)]
    public void MaximumBeauty_WithArrayAndK_ReturnsMaximizedBeauty(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumBeauty(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}