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

using LeetCode.Algorithms.SmallestPairWithDifferentFrequencies;

namespace LeetCode.Tests.Algorithms.SmallestPairWithDifferentFrequencies;

public abstract class SmallestPairWithDifferentFrequenciesTestsBase<T> where T : ISmallestPairWithDifferentFrequencies, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 5 }, new[] { -1, -1 })]
    [DataRow(new[] { 7 }, new[] { -1, -1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { -1, -1 })]
    [DataRow(new[] { 1, 1, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 5, 5, 6, 6, 6 }, new[] { 5, 6 })]
    [DataRow(new[] { 3, 3, 3, 3 }, new[] { -1, -1 })]
    [DataRow(new[] { 2, 2, 2, 3, 3, 3 }, new[] { -1, -1 })]
    [DataRow(new[] { 1, 2, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 4, 4, 5 }, new[] { 4, 5 })]
    [DataRow(new[] { 10, 10, 10, 20, 20 }, new[] { 10, 20 })]
    [DataRow(new[] { 0, 0, 1, 1 }, new[] { -1, -1 })]
    [DataRow(new[] { 0, 1, 1, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 50, 50, 51 }, new[] { 50, 51 })]
    [DataRow(new[] { 1, 1, 1, 1, 2, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 3, 4, 4, 4 }, new[] { 3, 4 })]
    [DataRow(new[] { 2, 2, 3, 3, 4 }, new[] { 2, 4 })]
    [DataRow(new[] { 1, 1, 2, 2, 2, 3, 3, 3 }, new[] { 1, 2 })]
    [DataRow(new[] { 7, 8, 8, 9, 9 }, new[] { 7, 8 })]
    [DataRow(new[] { 100, 100, 99, 99 }, new[] { -1, -1 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 6, 6, 7, 7, 8 }, new[] { 6, 8 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, new[] { -1, -1 })]
    [DataRow(new[] { 30, 30, 30, 40 }, new[] { 30, 40 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    public void MinDistinctFreqPair_WithInputNums_ReturnsSmallestPairWithDifferentFrequencies(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDistinctFreqPair(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}