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

using LeetCode.Algorithms.FindThePowerOfKSizeSubarrays1;

namespace LeetCode.Tests.Algorithms.FindThePowerOfKSizeSubarrays1;

public abstract class FindThePowerOfKSizeSubarrays1TestsBase<T> where T : IFindThePowerOfKSizeSubarrays1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 3, 2, 5 }, 3, new[] { 3, 4, -1, -1, -1 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 4, new[] { -1, -1 })]
    [DataRow(new[] { 3, 2, 3, 2, 3, 2 }, 2, new[] { -1, 3, -1, 3, -1 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 5 }, 1, new[] { 5 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 2 })]
    [DataRow(new[] { 2, 1 }, 2, new[] { -1 })]
    [DataRow(new[] { 1, 2, 3 }, 3, new[] { 3 })]
    [DataRow(new[] { 3, 2, 1 }, 3, new[] { -1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 5 })]
    [DataRow(new[] { 1, 2, 3, 5, 6, 7 }, 3, new[] { 3, -1, -1, 7 })]
    [DataRow(new[] { 5, 5, 5, 5 }, 2, new[] { -1, -1, -1 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, new[] { 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 4, 5 }, 2, new[] { 2, -1, 5 })]
    [DataRow(new[] { 10, 11, 12 }, 3, new[] { 12 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 4, new[] { 4, 5, 6 })]
    [DataRow(new[] { 1, 3, 2, 3 }, 3, new[] { -1, -1 })]
    [DataRow(new[] { 100000, 99999 }, 2, new[] { -1 })]
    [DataRow(new[] { 99999, 100000 }, 2, new[] { 100000 })]
    [DataRow(new[] { 4, 5, 6, 7, 1, 2, 3 }, 3, new[] { 6, 7, -1, -1, 3 })]
    [DataRow(new[] { 1, 2, 1, 2, 3 }, 3, new[] { -1, -1, 3 })]
    [DataRow(new[] { 7, 8, 9, 10 }, 4, new[] { 10 })]
    [DataRow(new[] { 9, 8, 7, 6 }, 2, new[] { -1, -1, -1 })]
    [DataRow(new[] { 1, 2, 3, 2, 3, 4 }, 3, new[] { 3, -1, -1, 4 })]
    [DataRow(new[] { 1, 1, 2, 3 }, 3, new[] { -1, 3 })]
    [DataRow(new[] { 10, 11, 13, 14, 15 }, 3, new[] { -1, -1, 15 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new[] { 8 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5, new[] { 5, 6, 7, 8 })]
    [DataRow(new[] { 2, 3, 4, 6, 7, 8, 9 }, 4, new[] { -1, -1, -1, 9 })]
    [DataRow(new[] { 50, 51, 52, 53 }, 1, new[] { 50, 51, 52, 53 })]
    [DataRow(new[] { 1, 2, 2, 3 }, 2, new[] { 2, -1, 3 })]
    public void ResultsArray_WithInputArrayAndK_ReturnsTransformedArray(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResultsArray(nums, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}