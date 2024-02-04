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

using LeetCode.Algorithms.ConcatenationOfArray;

namespace LeetCode.Tests.Algorithms.ConcatenationOfArray;

public abstract class ConcatenationOfArrayTestsBase<T> where T : IConcatenationOfArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [DataRow(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
    public void GetConcatenation_WithInputArray_ReturnsConcatenatedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetConcatenation(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}