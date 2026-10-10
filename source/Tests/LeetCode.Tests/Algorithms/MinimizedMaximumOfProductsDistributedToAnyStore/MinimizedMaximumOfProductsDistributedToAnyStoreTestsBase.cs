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

public abstract class MinimizedMaximumOfProductsDistributedToAnyStoreTestsBase<T> where T : IMinimizedMaximumOfProductsDistributedToAnyStore, new()
{
    [TestMethod]
    [DataRow(6, new[] { 11, 6 }, 3)]
    [DataRow(7, new[] { 15, 10, 10 }, 5)]
    [DataRow(1, new[] { 100000 }, 100000)]
    [DataRow(1, new[] { 1 }, 1)]
    [DataRow(2, new[] { 1, 1 }, 1)]
    [DataRow(2, new[] { 5 }, 3)]
    [DataRow(3, new[] { 5 }, 2)]
    [DataRow(5, new[] { 10, 1 }, 3)]
    [DataRow(3, new[] { 1, 1, 1 }, 1)]
    [DataRow(10, new[] { 1, 2, 3 }, 1)]
    [DataRow(4, new[] { 7, 7 }, 4)]
    [DataRow(5, new[] { 100, 100, 100 }, 100)]
    [DataRow(100, new[] { 1 }, 1)]
    [DataRow(6, new[] { 2, 3, 4, 5 }, 3)]
    [DataRow(7, new[] { 10, 20 }, 5)]
    [DataRow(3, new[] { 100, 1, 1 }, 100)]
    [DataRow(8, new[] { 3, 9, 27 }, 6)]
    [DataRow(20, new[] { 50, 60, 70 }, 10)]
    [DataRow(4, new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(2, new[] { 99999, 1 }, 99999)]
    public void MinimizedMaximum_WithNumberOfStoresAndProductQuantities_ReturnsMinimumPossibleMaximum(int n, int[] quantities, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimizedMaximum(n, quantities);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}