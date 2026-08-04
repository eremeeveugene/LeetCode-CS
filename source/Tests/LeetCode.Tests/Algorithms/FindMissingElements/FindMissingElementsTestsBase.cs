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

using LeetCode.Algorithms.FindMissingElements;

namespace LeetCode.Tests.Algorithms.FindMissingElements;

public abstract class FindMissingElementsTestsBase<T> where T : IFindMissingElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 2, 5 }, new[] { 3 })]
    [DataRow(new[] { 7, 8, 6, 9 }, new int[] { })]
    [DataRow(new[] { 5, 1 }, new[] { 2, 3, 4 })]
    [DataRow(new[] { 1, 2 }, new int[] { })]
    [DataRow(new[] { 2, 1 }, new int[] { })]
    [DataRow(new[] { 1, 3 }, new[] { 2 })]
    [DataRow(new[] { 3, 1 }, new[] { 2 })]
    [DataRow(new[] { 1, 5 }, new[] { 2, 3, 4 })]
    [DataRow(new[] { 2, 4 }, new[] { 3 })]
    [DataRow(new[] { 10, 20 }, new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new int[] { })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, new[] { 2, 4, 6, 8 })]
    [DataRow(new[] { 50, 51 }, new int[] { })]
    [DataRow(new[] { 50, 55 }, new[] { 51, 52, 53, 54 })]
    [DataRow(new[] { 1, 20 }, new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
    [DataRow(new[] { 99, 100 }, new int[] { })]
    [DataRow(new[] { 95, 100 }, new[] { 96, 97, 98, 99 })]
    [DataRow(new[] { 1, 6, 2, 3, 5 }, new[] { 4 })]
    [DataRow(new[] { 8, 3, 5 }, new[] { 4, 6, 7 })]
    [DataRow(new[] { 30, 10, 20 }, new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29 })]
    public void FindMissingElements_WithArrayContainingGaps_ReturnsMissingSequentialElements(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMissingElements(nums).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}