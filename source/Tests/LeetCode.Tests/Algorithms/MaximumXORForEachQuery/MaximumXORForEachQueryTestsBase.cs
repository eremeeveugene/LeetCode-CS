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

using LeetCode.Algorithms.MaximumXORForEachQuery;

namespace LeetCode.Tests.Algorithms.MaximumXORForEachQuery;

public abstract class MaximumXORForEachQueryTestsBase<T> where T : IMaximumXORForEachQuery, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 1, 3 }, 2, new[] { 0, 3, 2, 3 })]
    [DataRow(new[] { 2, 3, 4, 7 }, 3, new[] { 5, 2, 6, 5 })]
    [DataRow(new[] { 0, 1, 2, 2, 5, 7 }, 3, new[] { 4, 3, 6, 4, 6, 7 })]
    [DataRow(new[] { 0 }, 1, new[] { 1 })]
    [DataRow(new[] { 1 }, 1, new[] { 0 })]
    [DataRow(new[] { 0, 0 }, 1, new[] { 1, 1 })]
    [DataRow(new[] { 3 }, 2, new[] { 0 })]
    [DataRow(new[] { 1, 2, 3 }, 2, new[] { 3, 0, 2 })]
    [DataRow(new[] { 0, 1, 2, 3 }, 2, new[] { 3, 0, 2, 3 })]
    [DataRow(new[] { 5, 5, 5 }, 3, new[] { 2, 7, 2 })]
    [DataRow(new[] { 7 }, 3, new[] { 0 })]
    [DataRow(new[] { 1, 3, 5, 7 }, 3, new[] { 7, 0, 5, 6 })]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 4, new[] { 15, 15, 15, 15, 15 })]
    [DataRow(new[] { 1, 2, 4, 8 }, 4, new[] { 0, 8, 12, 14 })]
    [DataRow(new[] { 15, 15 }, 4, new[] { 15, 0 })]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 4, new[] { 1, 13, 7, 15, 9, 13 })]
    [DataRow(new[] { 100, 200, 300, 400 }, 9, new[] { 495, 127, 339, 411 })]
    [DataRow(new[] { 1, 1, 2, 3, 5, 8, 13, 21 }, 5, new[] { 11, 30, 19, 27, 30, 29, 31, 30 })]
    [DataRow(new[] { 1023, 1023, 1023 }, 10, new[] { 0, 1023, 0 })]
    [DataRow(new[] { 524287, 524287 }, 19, new[] { 524287, 0 })]
    public void GetMaximumXor_WithNumsArrayAndMaximumBit_ComputesXorValues(int[] nums, int maximumBit, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetMaximumXor(nums, maximumBit);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}