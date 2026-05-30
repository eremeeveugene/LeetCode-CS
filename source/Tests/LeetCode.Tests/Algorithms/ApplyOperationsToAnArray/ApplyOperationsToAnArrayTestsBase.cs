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

using LeetCode.Algorithms.ApplyOperationsToAnArray;

namespace LeetCode.Tests.Algorithms.ApplyOperationsToAnArray;

public abstract class ApplyOperationsToAnArrayTestsBase<T> where T : IApplyOperationsToAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1 }, new[] { 1, 0 })]
    [DataRow(new[] { 1, 2, 2, 1, 1, 0 }, new[] { 1, 4, 2, 0, 0, 0 })]
    public void ApplyOperations_WithGivenNumbersArray_ReturnsTransformedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ApplyOperations(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}