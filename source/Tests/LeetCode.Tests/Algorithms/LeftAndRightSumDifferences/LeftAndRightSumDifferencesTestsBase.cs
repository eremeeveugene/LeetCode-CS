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

using LeetCode.Algorithms.LeftAndRightSumDifferences;

namespace LeetCode.Tests.Algorithms.LeftAndRightSumDifferences;

public abstract class LeftAndRightSumDifferencesTestsBase<T> where T : ILeftAndRightSumDifferences, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 0 })]
    [DataRow(new[] { 10, 4, 8, 3 }, new[] { 15, 1, 11, 22 })]
    public void LeftRightDifference_WithGivenNumbers_ReturnsCorrectDifferences(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LeftRightDifference(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}