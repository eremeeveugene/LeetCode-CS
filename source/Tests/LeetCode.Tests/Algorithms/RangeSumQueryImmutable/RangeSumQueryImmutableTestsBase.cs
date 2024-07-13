// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RangeSumQueryImmutable;

namespace LeetCode.Tests.Algorithms.RangeSumQueryImmutable;

public abstract class RangeSumQueryImmutableTestsBase<T> where T : IRangeSumQueryImmutableFactory, new()
{
    [TestMethod]
    [DataRow(new[] { -2, 0, 3, -5, 2, -1 }, new[] { 0, 2, 0 }, new[] { 2, 5, 5 }, new[] { 1, -1, -3 })]
    public void SumRangeQuery_WithGivenArrays_ReturnsCorrectSumRange(int[] nums, int[] lefts, int[] rights,
        int[] expectedResults)
    {
        // Arrange
        var rangeSumQueryImmutableFactory = new T();
        var rangeSumQueryImmutable = rangeSumQueryImmutableFactory.Create(nums);

        // Act
        var actualResults = new int[expectedResults.Length];

        for (var i = 0; i < actualResults.Length; i++)
        {
            actualResults[i] = rangeSumQueryImmutable.SumRange(lefts[i], rights[i]);
        }

        // Assert
        CollectionAssert.AreEqual(actualResults, expectedResults);
    }
}