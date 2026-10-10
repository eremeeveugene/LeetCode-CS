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

using LeetCode.Algorithms.FirstUniqueEvenElement;

namespace LeetCode.Tests.Algorithms.FirstUniqueEvenElement;

public abstract class FirstUniqueEvenElementTestsBase<T> where T : IFirstUniqueEvenElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 4, 2, 5, 4, 6 }, 2)]
    [DataRow(new[] { 4, 4 }, -1)]
    [DataRow(new[] { 2 }, 2)]
    [DataRow(new[] { 1 }, -1)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 99 }, -1)]
    [DataRow(new[] { 1, 3, 5 }, -1)]
    [DataRow(new[] { 2, 2, 2 }, -1)]
    [DataRow(new[] { 2, 4 }, 2)]
    [DataRow(new[] { 4, 2, 4 }, 2)]
    [DataRow(new[] { 1, 2, 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 100, 100, 98 }, 98)]
    [DataRow(new[] { 98, 100, 100 }, 98)]
    [DataRow(new[] { 6, 6, 8, 8, 10 }, 10)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 10)]
    [DataRow(new[] { 50, 51, 50, 52, 53, 52 }, -1)]
    [DataRow(new[] { 2, 4, 6, 8, 2, 4, 6, 8 }, -1)]
    [DataRow(new[] { 3, 6, 3, 6, 9, 12 }, 12)]
    [DataRow(new[] { 100, 99, 100, 98, 97, 98, 2 }, 2)]
    [DataRow(new[] { 80, 33, 95, 46, 89, 95, 84, 68, 4, 60, 100, 32, 84, 7, 21, 15, 48, 61, 32, 49, 70, 14, 74, 32, 2, 94, 28, 53, 36, 24, 99, 50, 21, 98, 10, 18, 80, 80, 57, 17 }, 46)]
    public void FirstUniqueEven_WithGivenArray_ReturnsFirstEvenAppearingOnceOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstUniqueEven(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}