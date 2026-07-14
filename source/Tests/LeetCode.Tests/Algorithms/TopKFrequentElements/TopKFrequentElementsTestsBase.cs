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

using LeetCode.Algorithms.TopKFrequentElements;

namespace LeetCode.Tests.Algorithms.TopKFrequentElements;

public abstract class TopKFrequentElementsTestsBase<T> where T : ITopKFrequentElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 4, 4, 4, 4 }, 1, new[] { 4 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 1, new[] { 3 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 2, new[] { 3, 2 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 3, new[] { 1, 2, 3 })]
    [DataRow(new[] { -1, -1, -2, -2, -2, -3 }, 2, new[] { -2, -1 })]
    [DataRow(new[] { 0, 0, 0, 1, 1, 2 }, 2, new[] { 0, 1 })]
    [DataRow(new[] { 5, 3, 5, 3, 5, 3 }, 2, new[] { 5, 3 })]
    [DataRow(new[] { 7 }, 1, new[] { 7 })]
    [DataRow(new[] { -5, -5, -5, -5, -5 }, 1, new[] { -5 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3, 3, 4 }, 1, new[] { 1 })]
    [DataRow(new[] { 2, 2, 2, 1, 1, 3 }, 1, new[] { 2 })]
    [DataRow(new[] { 6, 6, 6, 6, 5, 5, 5, 4, 4, 3 }, 3, new[] { 6, 5, 4 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 3, new[] { 4, 3, 2 })]
    [DataRow(new[] { 7, 7, 7, 7, 9, 9, 9, 8, 8 }, 2, new[] { 7, 9 })]
    [DataRow(new[] { 100, 200, 100, 300, 300, 300 }, 1, new[] { 300 })]
    [DataRow(new[] { 100, 200, 100, 300, 300, 300 }, 2, new[] { 300, 100 })]
    [DataRow(new[] { -1, 0, 1, -1, 0, -1 }, 2, new[] { -1, 0 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 3, new[] { 1, 2, 3 })]
    [DataRow(new[] { 3, 0, 1, 0, 1, 0 }, 2, new[] { 0, 1 })]
    [DataRow(new[] { 10, 10, 20, 20, 20, 30 }, 1, new[] { 20 })]
    public void TopKFrequent_WithGivenArrayAndK_ReturnsKMostFrequentElements(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TopKFrequent(nums, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}