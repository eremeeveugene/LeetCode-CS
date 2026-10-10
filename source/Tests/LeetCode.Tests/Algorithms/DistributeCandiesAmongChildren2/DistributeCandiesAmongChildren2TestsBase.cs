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

using LeetCode.Algorithms.DistributeCandiesAmongChildren2;

namespace LeetCode.Tests.Algorithms.DistributeCandiesAmongChildren2;

public abstract class DistributeCandiesAmongChildren2TestsBase<T> where T : IDistributeCandiesAmongChildren2, new()
{
    [TestMethod]
    [DataRow(5, 2, 3)]
    [DataRow(3, 3, 10)]
    [DataRow(1, 1, 3)]
    [DataRow(1, 5, 3)]
    [DataRow(2, 1, 3)]
    [DataRow(2, 2, 6)]
    [DataRow(4, 1, 0)]
    [DataRow(6, 2, 1)]
    [DataRow(10, 3, 0)]
    [DataRow(10, 10, 66)]
    [DataRow(10, 1, 0)]
    [DataRow(7, 3, 6)]
    [DataRow(20, 5, 0)]
    [DataRow(15, 15, 136)]
    [DataRow(30, 10, 1)]
    [DataRow(100, 1, 0)]
    [DataRow(100, 40, 231)]
    [DataRow(1000, 100, 0)]
    [DataRow(1000000, 1000000, 500001500001)]
    [DataRow(1000000, 1, 0)]
    public void DistributeCandies_WithTotalCandiesAndLimit_ReturnsTheTotalNumberOfWaysToDistributeCandies(int n, int limit, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DistributeCandies(n, limit);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}