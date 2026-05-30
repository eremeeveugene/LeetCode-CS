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

using LeetCode.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;

namespace LeetCode.Tests.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;

public abstract class MinimizedMaximumOfProductsDistributedToAnyStoreTestsBase<T>
    where T : IMinimizedMaximumOfProductsDistributedToAnyStore, new()
{
    [TestMethod]
    [DataRow(6, new[] { 11, 6 }, 3)]
    [DataRow(7, new[] { 15, 10, 10 }, 5)]
    [DataRow(1, new[] { 100000 }, 100000)]
    public void MinimizedMaximum_WithNumberOfStoresAndProductQuantities_ReturnsMinimumPossibleMaximum(int n,
        int[] quantities, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimizedMaximum(n, quantities);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}