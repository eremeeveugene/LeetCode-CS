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

using LeetCode.Algorithms.SingleNumber3;

namespace LeetCode.Tests.Algorithms.SingleNumber3;

public abstract class SingleNumber3TestsBase<T> where T : ISingleNumber3, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 3, 2, 5 }, new[] { 3, 5 })]
    [DataRow(new[] { -1, 0 }, new[] { -1, 0 })]
    [DataRow(new[] { 0, 1 }, new[] { 1, 0 })]
    [DataRow(new[] { 1, 1, 2, 3 }, new[] { 2, 3 })]
    [DataRow(new[] { -5, -5, 7, 8 }, new[] { 7, 8 })]
    [DataRow(new[] { 0, 5, 5, 6 }, new[] { 0, 6 })]
    [DataRow(new[] { 2147483647, -2147483648 }, new[] { 2147483647, -2147483648 })]
    [DataRow(new[] { 2147483647, 2147483647, -2147483648, 0 }, new[] { -2147483648, 0 })]
    [DataRow(new[] { -2147483648, 3, 3, -1 }, new[] { -2147483648, -1 })]
    [DataRow(new[] { 4, 4, 9, 9, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 10, 20 }, new[] { 10, 20 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { -1, -2 }, new[] { -1, -2 })]
    [DataRow(new[] { 100, 100, -100, 200 }, new[] { -100, 200 })]
    [DataRow(new[] { 8, 9, 8, 10 }, new[] { 9, 10 })]
    [DataRow(new[] { 0, 1, 0, 2, 1, 3 }, new[] { 2, 3 })]
    [DataRow(new[] { 11, 12, 13, 11, 12, 14 }, new[] { 13, 14 })]
    [DataRow(new[] { -7, -7, 15, 16, 16, 17 }, new[] { 15, 17 })]
    [DataRow(new[] { 5, 6 }, new[] { 5, 6 })]
    [DataRow(new[] { 3, 3, 4, 5 }, new[] { 4, 5 })]
    public void SingleNumber_WithIntegerArray_ReturnsTwoUniqueNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}