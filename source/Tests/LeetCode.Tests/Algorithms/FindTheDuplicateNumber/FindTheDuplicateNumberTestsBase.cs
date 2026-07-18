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

using LeetCode.Algorithms.FindTheDuplicateNumber;

namespace LeetCode.Tests.Algorithms.FindTheDuplicateNumber;

public abstract class FindTheDuplicateNumberTestsBase<T> where T : IFindTheDuplicateNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 4, 2, 2 }, 2)]
    [DataRow(new[] { 3, 1, 3, 4, 2 }, 3)]
    [DataRow(new[] { 3, 3, 3, 3, 3 }, 3)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 2, 2, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 4 }, 4)]
    [DataRow(new[] { 4, 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 1, 2, 2, 3, 4 }, 2)]
    [DataRow(new[] { 2, 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 3, 1 }, 1)]
    [DataRow(new[] { 5, 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 1, 4, 4, 2, 3 }, 4)]
    [DataRow(new[] { 2, 5, 9, 6, 9, 3, 8, 9, 7, 1 }, 9)]
    [DataRow(new[] { 6, 4, 3, 2, 1, 5, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 3 }, 3)]
    [DataRow(new[] { 7, 9, 7, 4, 2, 8, 6, 1, 3, 5 }, 7)]
    [DataRow(new[] { 1, 2, 1 }, 1)]
    [DataRow(new[] { 2, 3, 2, 4 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 2 }, 2)]
    [DataRow(new[] { 3, 2, 1, 3 }, 3)]
    [DataRow(new[] { 5, 2, 1, 3, 5, 7, 6, 4 }, 5)]
    public void FindDuplicate_GivenArray_ReturnsFirstDuplicate(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDuplicate(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}