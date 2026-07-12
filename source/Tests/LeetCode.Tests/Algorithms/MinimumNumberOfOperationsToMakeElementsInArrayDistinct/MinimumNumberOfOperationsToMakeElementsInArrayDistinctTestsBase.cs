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

using LeetCode.Algorithms.MinimumNumberOfOperationsToMakeElementsInArrayDistinct;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMakeElementsInArrayDistinct;

public abstract class MinimumNumberOfOperationsToMakeElementsInArrayDistinctTestsBase<T>
    where T : IMinimumNumberOfOperationsToMakeElementsInArrayDistinct, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 2, 3, 3, 5, 7 }, 2)]
    [DataRow(new[] { 4, 5, 6, 4, 4 }, 2)]
    [DataRow(new[] { 6, 7, 8, 9 }, 0)]
    public void MinimumOperations_GivenArrayOfNumbers_ReturnsMinimumOperationsCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}