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

using LeetCode.Algorithms.CheckIfArrayIsSortedAndRotated;

namespace LeetCode.Tests.Algorithms.CheckIfArrayIsSortedAndRotated;

public abstract class CheckIfArrayIsSortedAndRotatedTestsBase<T> where T : ICheckIfArrayIsSortedAndRotated, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 4, 5, 1, 2 }, true)]
    [DataRow(new[] { 2, 1, 3, 4 }, false)]
    [DataRow(new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2, 2 }, true)]
    [DataRow(new[] { 1, 1, 1, 1 }, true)]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { 3, 1, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, false)]
    [DataRow(new[] { 3, 3, 1, 1, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 1 }, true)]
    [DataRow(new[] { 3, 4, 5, 1, 1, 2 }, true)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 2, 3, 4, 5, 1 }, true)]
    [DataRow(new[] { 1, 3, 2 }, false)]
    [DataRow(new[] { 4, 5, 1, 2, 3 }, true)]
    public void Check_GivenNums_ReturnsIfSortedOrRotated(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Check(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}