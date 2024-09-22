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

using LeetCode.Algorithms.KthSmallestInLexicographicalOrder;

namespace LeetCode.Tests.Algorithms.KthSmallestInLexicographicalOrder;

public abstract class KthSmallestInLexicographicalOrderTestsBase<T> where T : IKthSmallestInLexicographicalOrder, new()
{
    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(13, 2, 10)]
    [DataRow(272938424, 142648193, 22838337)]
    [DataRow(1000000000, 374924728, 43743225)]
    [DataRow(1000000000, 500000000, 549999998)]
    [DataRow(1000000000, 999945398, 999950855)]
    [DataRow(1000000000, 1000000000, 999999999)]
    [DataRow(1000000000, 1, 1)]
    public void FindKthNumber_WithNAndK_ReturnsKthLexicographicalNumber(int n, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindKthNumber(n, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}