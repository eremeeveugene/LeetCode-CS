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

using LeetCode.Algorithms.SingleNumber3;

namespace LeetCode.Tests.Algorithms.SingleNumber3;

public abstract class SingleNumber3TestsBase<T> where T : ISingleNumber3, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 3, 2, 5 }, new[] { 3, 5 })]
    [DataRow(new[] { -1, 0 }, new[] { -1, 0 })]
    [DataRow(new[] { 0, 1 }, new[] { 1, 0 })]
    public void SingleNumber_WithIntegerArray_ReturnsTwoUniqueNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}