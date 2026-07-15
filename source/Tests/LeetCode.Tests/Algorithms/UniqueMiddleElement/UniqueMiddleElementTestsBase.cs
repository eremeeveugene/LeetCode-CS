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

using LeetCode.Algorithms.UniqueMiddleElement;

namespace LeetCode.Tests.Algorithms.UniqueMiddleElement;

public abstract class UniqueMiddleElementTestsBase<T> where T : IUniqueMiddleElement, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 1, 2, 2 }, false)]
    [DataRow(new[] { 5 }, true)]
    [DataRow(new[] { 1, 1, 1 }, false)]
    [DataRow(new[] { 1, 2, 1 }, true)]
    [DataRow(new[] { 3, 3, 3, 3, 3 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, true)]
    [DataRow(new[] { 2, 1, 3, 1, 2 }, true)]
    [DataRow(new[] { 1, 3, 3, 3, 1 }, false)]
    [DataRow(new[] { 7, 8, 9 }, true)]
    [DataRow(new[] { 4, 4, 5 }, false)]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, true)]
    [DataRow(new[] { 1, 1, 2, 1, 1 }, true)]
    [DataRow(new[] { 2, 2, 2, 2, 1 }, false)]
    [DataRow(new[] { 100, 50, 100 }, true)]
    [DataRow(new[] { 50, 100, 50 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, true)]
    [DataRow(new[] { 1, 2, 4, 4, 4, 2, 1 }, false)]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, false)]
    [DataRow(new[] { 8, 8, 7, 6, 6 }, true)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true)]
    public void HasUniqueMiddleElement_WithOddLengthArray_ReturnsWhetherMiddleElementIsUnique(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasUniqueMiddleElement(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}