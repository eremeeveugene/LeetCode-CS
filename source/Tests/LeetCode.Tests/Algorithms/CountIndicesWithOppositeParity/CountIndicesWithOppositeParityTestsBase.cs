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

using LeetCode.Algorithms.CountIndicesWithOppositeParity;

namespace LeetCode.Tests.Algorithms.CountIndicesWithOppositeParity;

public abstract class CountIndicesWithOppositeParityTestsBase<T> where T : ICountIndicesWithOppositeParity, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 0 })]
    [DataRow(new[] { 2 }, new[] { 0 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 0 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 0 })]
    [DataRow(new[] { 1, 3 }, new[] { 0, 0 })]
    [DataRow(new[] { 2, 4 }, new[] { 0, 0 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 1, 0 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 1, 3, 5, 7 }, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 1, 2, 1, 2 }, new[] { 2, 1, 1, 0 })]
    [DataRow(new[] { 2, 1, 2, 1 }, new[] { 2, 1, 1, 0 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 2, 2, 0, 0 })]
    [DataRow(new[] { 2, 2, 1, 1 }, new[] { 2, 2, 0, 0 })]
    [DataRow(new[] { 1, 2, 2, 2 }, new[] { 3, 0, 0, 0 })]
    [DataRow(new[] { 2, 1, 1, 1 }, new[] { 3, 0, 0, 0 })]
    [DataRow(new[] { 1, 100, 99, 98 }, new[] { 2, 1, 1, 0 })]
    [DataRow(new[] { 100, 99, 98, 97 }, new[] { 2, 1, 1, 0 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 2, 2, 1, 1, 0 })]
    [DataRow(new[] { 2, 1, 4, 3, 6 }, new[] { 2, 2, 1, 1, 0 })]
    public void CountOppositeParity_WithGivenNums_ReturnsCountOfSubsequentOppositeParityIndices(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountOppositeParity(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}