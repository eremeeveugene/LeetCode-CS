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

using LeetCode.Algorithms.FindXSumOfAllKLongSubarrays1;

namespace LeetCode.Tests.Algorithms.FindXSumOfAllKLongSubarrays1;

public abstract class FindXSumOfAllKLongSubarrays1TestsBase<T> where T : IFindXSumOfAllKLongSubarrays1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4, 2, 3 }, 6, 2, new[] { 6, 10, 12 })]
    [DataRow(new[] { 3, 8, 7, 8, 7, 5 }, 2, 2, new[] { 11, 15, 15, 15, 12 })]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 3, 1, new[] { 2, 4, 2, 4 })]
    [DataRow(new[] { 5, 5, 5, 5 }, 2, 1, new[] { 10, 10, 10 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 3, new[] { 12 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 5, new[] { 15 })]
    [DataRow(new[] { 4, 4, 4, 3, 3 }, 3, 2, new[] { 12, 11, 10 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 4, 1, new[] { 4, 4, 6 })]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 1, 1, new[] { 9, 8, 7, 6, 5 })]
    [DataRow(new[] { 1 }, 1, 1, new[] { 1 })]
    [DataRow(new[] { 50, 50 }, 2, 1, new[] { 100 })]
    [DataRow(new[] { 1, 3, 2, 3, 1, 3 }, 4, 2, new[] { 8, 8, 8 })]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 3, 3, new[] { 6, 6, 6, 6, 6, 6, 6 })]
    [DataRow(new[] { 2, 2, 3, 3, 3, 2, 2 }, 5, 2, new[] { 13, 13, 13 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 9, 2, new[] { 15 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 9, 1, new[] { 9 })]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7 }, 7, 1, new[] { 49 })]
    [DataRow(new[] { 1, 2 }, 1, 1, new[] { 1, 2 })]
    [DataRow(new[] { 10, 20, 10, 20, 10 }, 4, 2, new[] { 60, 60 })]
    [DataRow(new[] { 6, 1, 6, 1, 6, 1, 6 }, 3, 1, new[] { 12, 2, 12, 2, 12 })]
    [DataRow(new[] { 5, 3, 5, 3, 5, 3, 5 }, 5, 1, new[] { 15, 9, 15 })]
    public void FindXSum_WithNumsKAndX_ReturnsXSumOfEachSubarray(int[] nums, int k, int x, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindXSum(nums, k, x);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}