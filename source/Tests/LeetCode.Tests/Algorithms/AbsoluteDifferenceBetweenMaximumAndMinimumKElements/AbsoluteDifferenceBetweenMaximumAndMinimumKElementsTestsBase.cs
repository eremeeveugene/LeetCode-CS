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

using LeetCode.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

namespace LeetCode.Tests.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

public abstract class AbsoluteDifferenceBetweenMaximumAndMinimumKElementsTestsBase<T>
    where T : IAbsoluteDifferenceBetweenMaximumAndMinimumKElements, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 2, 4 }, 2, 5)]
    [DataRow(new[] { 100 }, 1, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 6)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, 6)]
    [DataRow(new[] { 10, 20, 30 }, 1, 20)]
    [DataRow(new[] { 10, 20, 30 }, 2, 20)]
    [DataRow(new[] { 7, 7, 7, 7 }, 2, 0)]
    [DataRow(new[] { 4, 1, 9, 3, 8 }, 2, 13)]
    [DataRow(new[] { 9, 1, 5, 2, 8, 3 }, 3, 16)]
    [DataRow(new[] { 6, 6, 1, 1, 10, 10 }, 2, 18)]
    [DataRow(new[] { 2, 100, 50, 1 }, 1, 99)]
    [DataRow(new[] { 2, 100, 50, 1 }, 2, 147)]
    [DataRow(new[] { 11, 4, 7, 1, 9 }, 1, 10)]
    [DataRow(new[] { 11, 4, 7, 1, 9 }, 2, 15)]
    [DataRow(new[] { 3, 3, 3, 10 }, 1, 7)]
    [DataRow(new[] { 3, 3, 3, 10 }, 2, 7)]
    [DataRow(new[] { 1, 100 }, 1, 99)]
    [DataRow(new[] { 1, 2, 100, 99 }, 2, 196)]
    [DataRow(new[] { 8, 6, 4, 2 }, 2, 8)]
    public void AbsDifference_WithKSmallestAndKLargestElements_ReturnsAbsoluteDifferenceOfTheirSums(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AbsDifference(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}