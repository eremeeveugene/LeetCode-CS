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

using LeetCode.Algorithms.SubarraysWithKDifferentIntegers;

namespace LeetCode.Tests.Algorithms.SubarraysWithKDifferentIntegers;

public abstract class SubarraysWithKDifferentIntegersTestsBase<T> where T : ISubarraysWithKDifferentIntegers, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 2, 3 }, 2, 7)]
    [DataRow(new[] { 1, 2, 1, 3, 4 }, 3, 3)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 10)]
    [DataRow(new[] { 1, 2 }, 1, 2)]
    [DataRow(new[] { 1, 2 }, 2, 1)]
    [DataRow(new[] { 1, 2, 3 }, 3, 1)]
    [DataRow(new[] { 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 2, 2, 1, 2, 2, 2, 2, 2 }, 2, 17)]
    [DataRow(new[] { 1, 2, 1, 2, 3 }, 1, 5)]
    [DataRow(new[] { 1, 2, 1, 2, 3 }, 3, 3)]
    [DataRow(new[] { 1, 2, 1, 3, 4 }, 2, 5)]
    [DataRow(new[] { 1, 2, 1, 3, 4 }, 4, 2)]
    [DataRow(new[] { 3, 3, 3, 1, 1, 3 }, 2, 11)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 }, 4, 11)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 2, 28)]
    [DataRow(new[] { 4, 4, 4, 4, 4 }, 1, 15)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 3, 28)]
    [DataRow(new[] { 6, 5, 6, 5, 6, 7 }, 3, 4)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 3 }, 3, 11)]
    public void SubarraysWithKDistinct_WithArrayAndTargetDistinctCount_ReturnsNumberOfValidSubarrays(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubarraysWithKDistinct(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}