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

using LeetCode.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;

public abstract class MinimumOperationsToMakeBinaryArrayElementsEqualToOne1TestsBase<T>
    where T : IMinimumOperationsToMakeBinaryArrayElementsEqualToOne1, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 1, 1, 0, 0 }, 3)]
    [DataRow(new[] { 0, 1, 1, 1 }, -1)]
    [DataRow(new[] { 1, 0, 0, 1, 1, 0, 1, 1, 1 }, -1)]
    public void MinOperations_WithBinaryArray_ReturnsMinimumOperationsOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}