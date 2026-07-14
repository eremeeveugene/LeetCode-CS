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

using LeetCode.Algorithms.LeftAndRightSumDifferences;

namespace LeetCode.Tests.Algorithms.LeftAndRightSumDifferences;

public abstract class LeftAndRightSumDifferencesTestsBase<T> where T : ILeftAndRightSumDifferences, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 0 })]
    [DataRow(new[] { 100000 }, new[] { 0 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 100000 }, new[] { 100000, 1 })]
    [DataRow(new[] { 100000, 1 }, new[] { 1, 100000 })]
    [DataRow(new[] { 100000, 100000 }, new[] { 100000, 100000 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 2, 0, 2 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 5, 2, 3 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 3, 2, 5 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 10, 0, 10 })]
    [DataRow(new[] { 100, 200, 300 }, new[] { 500, 200, 300 })]
    [DataRow(new[] { 100000, 1, 100000 }, new[] { 100001, 0, 100001 })]
    [DataRow(new[] { 10, 4, 8, 3 }, new[] { 15, 1, 11, 22 })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 3, 1, 1, 3 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 9, 6, 1, 6 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 6, 1, 6, 9 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, new[] { 8, 4, 0, 4, 8 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 14, 11, 6, 1, 10 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 10, 1, 6, 11, 14 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 20, 17, 12, 5, 4, 15 })]
    [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, new[] { 19, 11, 5, 3, 12, 22 })]
    public void LeftRightDifference_WithInputArray_ReturnsAbsoluteLeftRightSums(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LeftRightDifference(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}