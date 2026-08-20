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

using LeetCode.Algorithms.DistributeElementsIntoTwoArrays1;

namespace LeetCode.Tests.Algorithms.DistributeElementsIntoTwoArrays1;

public abstract class DistributeElementsIntoTwoArrays1TestsBase<T> where T : IDistributeElementsIntoTwoArrays1, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3 }, new[] { 2, 3, 1 })]
    [DataRow(new[] { 5, 4, 3, 8 }, new[] { 5, 3, 4, 8 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 3, 1, 2 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 4, 2, 1, 3 }, new[] { 4, 1, 2, 3 })]
    [DataRow(new[] { 2, 4, 1, 3 }, new[] { 2, 3, 4, 1 })]
    [DataRow(new[] { 10, 5, 8, 3, 7 }, new[] { 10, 8, 3, 5, 7 })]
    [DataRow(new[] { 5, 10, 8, 3, 7 }, new[] { 5, 7, 10, 8, 3 })]
    [DataRow(new[] { 100, 1, 99, 2, 98, 3 }, new[] { 100, 99, 2, 98, 3, 1 })]
    [DataRow(new[] { 1, 100, 2, 99, 3, 98 }, new[] { 1, 100, 2, 99, 3, 98 })]
    [DataRow(new[] { 7, 3, 5, 1, 6, 2, 4 }, new[] { 7, 5, 1, 3, 6, 2, 4 })]
    [DataRow(new[] { 3, 7, 5, 1, 6, 2, 4 }, new[] { 3, 6, 2, 4, 7, 5, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 6, 4, 2, 5, 3, 1 })]
    [DataRow(new[] { 8, 1, 7, 6, 5, 4, 3, 2 }, new[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 2, 9, 8, 1, 7, 3, 6, 4, 5 }, new[] { 2, 7, 3, 6, 4, 5, 9, 8, 1 })]
    [DataRow(new[] { 50, 40, 30 }, new[] { 50, 30, 40 })]
    [DataRow(new[] { 40, 50, 30 }, new[] { 40, 50, 30 })]
    [DataRow(new[] { 1, 3, 2 }, new[] { 1, 3, 2 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 3, 1, 2 })]
    [DataRow(new[] { 100, 99, 1, 98, 2, 97, 3, 96 }, new[] { 100, 1, 99, 98, 2, 97, 3, 96 })]
    [DataRow(new[] { 99, 100, 1, 2, 3, 4, 5, 6 }, new[] { 99, 2, 3, 4, 5, 6, 100, 1 })]
    [DataRow(new[] { 20, 10, 30, 5, 25, 15 }, new[] { 20, 30, 5, 10, 25, 15 })]
    [DataRow(new[] { 4, 1, 3, 2, 6, 5 }, new[] { 4, 3, 2, 6, 5, 1 })]
    [DataRow(new[] { 6, 1, 5, 2, 4, 3 }, new[] { 6, 5, 2, 4, 3, 1 })]
    public void ResultArray_WithGivenNumbers_ReturnsDistributedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResultArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}