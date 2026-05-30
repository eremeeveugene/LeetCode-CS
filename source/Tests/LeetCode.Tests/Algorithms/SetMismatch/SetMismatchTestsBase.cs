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
    public void FindErrorNums_WithDuplicateAndMissingNumberInArray_ReturnsDuplicatedAndMissingNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindErrorNums(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}