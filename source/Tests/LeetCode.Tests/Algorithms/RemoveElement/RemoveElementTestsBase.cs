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

using LeetCode.Algorithms.RemoveElement;

namespace LeetCode.Tests.Algorithms.RemoveElement;

public abstract class RemoveElementTestsBase<T> where T : IRemoveElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 }, 2)]
    [DataRow(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 4, 0, 3 }, 5)]
    [DataRow(new int[] { }, 0, new int[] { }, 0)]
    [DataRow(new[] { 0 }, 0, new int[] { }, 0)]
    [DataRow(new[] { 1 }, 0, new[] { 1 }, 1)]
    [DataRow(new[] { 4, 5 }, 5, new[] { 4 }, 1)]
    [DataRow(new[] { 3, 3, 3 }, 3, new int[] { }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6, new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 2, 2, 2, 1 }, 2, new[] { 1 }, 1)]
    [DataRow(new[] { 1, 2, 2, 2 }, 2, new[] { 1 }, 1)]
    [DataRow(new[] { 0, 0, 1, 1, 0 }, 0, new[] { 1, 1 }, 2)]
    [DataRow(new[] { 50, 49, 48, 50, 47 }, 50, new[] { 49, 48, 47 }, 3)]
    [DataRow(new[] { 7, 8, 9 }, 100, new[] { 7, 8, 9 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, new[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }, 9)]
    [DataRow(new[] { 5, 1, 5, 2, 5, 3, 5, 4, 5 }, 5, new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 0, 50, 0, 50 }, 50, new[] { 0, 0 }, 2)]
    [DataRow(new[] { 37, 5, 28, 5, 34, 47, 23, 22, 28, 37, 0, 13, 21, 43, 0, 36, 23, 26, 12, 30, 48, 36, 40, 35, 8, 8, 15, 42, 4, 33, 4, 13, 15, 48, 13, 30, 14, 27, 14, 29, 27, 8, 14, 5, 50, 35, 1, 26, 21, 16 }, 25, new[] { 37, 5, 28, 5, 34, 47, 23, 22, 28, 37, 0, 13, 21, 43, 0, 36, 23, 26, 12, 30, 48, 36, 40, 35, 8, 8, 15, 42, 4, 33, 4, 13, 15, 48, 13, 30, 14, 27, 14, 29, 27, 8, 14, 5, 50, 35, 1, 26, 21, 16 }, 50)]
    [DataRow(new[] { 0, 2, 1, 3, 3, 0, 0, 0, 3, 0, 3, 0, 0, 2, 1, 2, 3, 0, 2, 3, 0, 3, 0, 3, 2, 1, 2, 1, 2, 1, 2, 2, 0, 2, 3, 0, 0, 2, 2, 1, 2, 1, 1, 0, 3, 1, 3, 2, 1, 2, 3, 2, 0, 2, 0, 3, 3, 2, 1, 0 }, 2, new[] { 0, 1, 3, 3, 0, 0, 0, 3, 0, 3, 0, 0, 1, 3, 0, 3, 0, 3, 0, 3, 1, 1, 1, 0, 3, 0, 0, 1, 1, 1, 0, 3, 1, 3, 1, 3, 0, 0, 3, 3, 1, 0 }, 42)]
    [DataRow(new[] { 17, 36, 28, 8, 47, 19, 5, 38, 48, 6, 50, 46, 50, 41, 39, 41, 21, 7, 50, 38, 47, 42, 7, 30, 33, 3, 18, 40, 32, 24, 36, 8, 4, 39, 45, 19, 42, 49, 23, 43, 2, 16, 47, 10, 24, 32, 16, 1, 3, 7, 27, 17, 15, 32, 0, 13, 37, 42, 22, 49, 47, 45, 46, 47, 5, 29, 26, 24, 16, 27, 1, 7, 5, 0, 32, 19, 6, 50, 4, 27, 10, 18, 23, 45, 5, 5, 48, 41, 7, 24, 6, 11, 4, 9, 16, 8, 31, 45, 43, 49 }, 17, new[] { 36, 28, 8, 47, 19, 5, 38, 48, 6, 50, 46, 50, 41, 39, 41, 21, 7, 50, 38, 47, 42, 7, 30, 33, 3, 18, 40, 32, 24, 36, 8, 4, 39, 45, 19, 42, 49, 23, 43, 2, 16, 47, 10, 24, 32, 16, 1, 3, 7, 27, 15, 32, 0, 13, 37, 42, 22, 49, 47, 45, 46, 47, 5, 29, 26, 24, 16, 27, 1, 7, 5, 0, 32, 19, 6, 50, 4, 27, 10, 18, 23, 45, 5, 5, 48, 41, 7, 24, 6, 11, 4, 9, 16, 8, 31, 45, 43, 49 }, 98)]
    [DataRow(new[] { 0, 0, 0, 1, 1, 2, 1, 0, 2, 0, 2, 0, 1, 2, 1, 1, 0, 1, 0, 0, 2, 2, 2, 0, 0, 1, 1, 1, 0, 2, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 2, 1, 0, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 2, 0, 2, 0, 2, 0, 1, 1, 2, 2, 0, 0, 2, 1, 2, 0, 1, 2, 0, 2, 2, 0, 0, 0, 2, 1, 2, 1, 1, 1, 1, 2, 0, 0, 0 }, 1, new[] { 0, 0, 0, 2, 0, 2, 0, 2, 0, 2, 0, 0, 0, 2, 2, 2, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 0, 2, 0, 0, 0, 0, 0, 2, 2, 0, 2, 0, 2, 0, 2, 2, 0, 0, 2, 2, 0, 2, 0, 2, 2, 0, 0, 0, 2, 2, 2, 0, 0, 0 }, 66)]
    public void RemoveElement_WithArrayAndValue_ReturnsModifiedArrayAndNewLength(int[] nums, int val, int[] expectedNums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveElement(nums, val);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);

        var actualNums = new int[actualResult];
        Array.Copy(nums, actualNums, actualResult);

        Assert.AreSequenceEqual(expectedNums, actualNums, SequenceOrder.InAnyOrder);
    }
}