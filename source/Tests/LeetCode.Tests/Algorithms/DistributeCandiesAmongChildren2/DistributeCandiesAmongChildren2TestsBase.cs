// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    public void DistributeCandies_WithTotalCandiesAndLimit_ReturnsTheTotalNumberOfWaysToDistributeCandies(int n,
        int limit, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DistributeCandies(n, limit);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}