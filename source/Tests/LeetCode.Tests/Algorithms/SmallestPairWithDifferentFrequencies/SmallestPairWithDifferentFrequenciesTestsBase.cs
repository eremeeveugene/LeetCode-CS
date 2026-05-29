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

public abstract class SmallestPairWithDifferentFrequenciesTestsBase<T>
    where T : ISmallestPairWithDifferentFrequencies, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 5 }, new[] { -1, -1 })]
    [DataRow(new[] { 7 }, new[] { -1, -1 })]
    public void MinDistinctFreqPair_WithInputNums_ReturnsSmallestPairWithDifferentFrequencies(int[] nums,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDistinctFreqPair(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}
