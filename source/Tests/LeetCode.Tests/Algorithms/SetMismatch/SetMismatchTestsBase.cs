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

using LeetCode.Algorithms.SetMismatch;

namespace LeetCode.Tests.Algorithms.SetMismatch;

public abstract class SetMismatchTestsBase<T> where T : ISetMismatch, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 4 }, new[] { 2, 3 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 2, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 3, 2, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2, 2 }, new[] { 2, 3 })]
    [DataRow(new[] { 2, 2, 3 }, new[] { 2, 1 })]
    [DataRow(new[] { 1, 3, 3 }, new[] { 3, 2 })]
    [DataRow(new[] { 3, 1, 3 }, new[] { 3, 2 })]
    [DataRow(new[] { 1, 2, 3, 3 }, new[] { 3, 4 })]
    [DataRow(new[] { 4, 4, 1, 2 }, new[] { 4, 3 })]
    [DataRow(new[] { 1, 5, 3, 2, 2 }, new[] { 2, 4 })]
    [DataRow(new[] { 2, 3, 4, 5, 5 }, new[] { 5, 1 })]
    [DataRow(new[] { 5, 3, 1, 2, 5 }, new[] { 5, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 7 }, new[] { 7, 8 })]
    [DataRow(new[] { 1, 1, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 2 })]
    [DataRow(new[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 9 }, new[] { 9, 1 })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 6 }, new[] { 6, 1 })]
    [DataRow(new[] { 2, 1, 4, 3, 6, 6, 8, 7 }, new[] { 6, 5 })]
    [DataRow(new[] { 1, 2, 4, 4 }, new[] { 4, 3 })]
    [DataRow(new[] { 2, 3, 2 }, new[] { 2, 1 })]
    public void FindErrorNums_WithDuplicateAndMissingNumberInArray_ReturnsDuplicatedAndMissingNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindErrorNums(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}