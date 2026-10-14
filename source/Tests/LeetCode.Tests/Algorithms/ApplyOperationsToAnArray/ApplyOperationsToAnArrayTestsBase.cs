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
    [DataRow(new[] { 1, 1 }, new[] { 2, 0 })]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 0, 1, 0, 2 }, new[] { 1, 2, 0, 0 })]
    [DataRow(new[] { 2, 2, 2 }, new[] { 4, 2, 0 })]
    [DataRow(new[] { 2, 2, 2, 2 }, new[] { 4, 4, 0, 0 })]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, new[] { 2, 2, 1, 0, 0 })]
    [DataRow(new[] { 3, 3, 6, 6 }, new[] { 6, 12, 0, 0 })]
    [DataRow(new[] { 0, 0, 1, 1 }, new[] { 2, 0, 0, 0 })]
    [DataRow(new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { 1000, 1000 }, new[] { 2000, 0 })]
    [DataRow(new[] { 1, 0, 1 }, new[] { 1, 1, 0 })]
    [DataRow(new[] { 4, 0, 0, 4 }, new[] { 4, 4, 0, 0 })]
    [DataRow(new[] { 2, 1, 1, 2 }, new[] { 2, 2, 2, 0 })]
    [DataRow(new[] { 1, 2, 2, 1 }, new[] { 1, 4, 1, 0 })]
    [DataRow(new[] { 2, 2, 0, 2, 2 }, new[] { 4, 4, 0, 0, 0 })]
    [DataRow(new[] { 7, 7, 7 }, new[] { 14, 7, 0 })]
    [DataRow(new[] { 10, 5, 5, 10 }, new[] { 10, 10, 10, 0 })]
    [DataRow(new[] { 1, 2, 3, 3 }, new[] { 1, 2, 6, 0 })]
    [DataRow(new[] { 8, 8, 4, 4, 2, 2 }, new[] { 16, 8, 4, 0, 0, 0 })]
    public void ApplyOperations_WithGivenNumbersArray_ReturnsTransformedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ApplyOperations(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}