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

using LeetCode.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;

public abstract class MinimizedMaximumOfProductsDistributedToAnyStoreTestsBase<T>
    where T : IMinimizedMaximumOfProductsDistributedToAnyStore, new()
{
    [TestMethod]
    [DataRow(6, "[11,6]", 3)]
    [DataRow(7, "[15,10,10]", 5)]
    [DataRow(1, "[100000]", 100000)]
    public void MinimizedMaximum_WithNumberOfStoresAndProductQuantities_ReturnsMinimumPossibleMaximum(int n,
        string quantitiesJson, int expectedResult)
    {
        // Arrange
        var quantities = JsonHelper<int[]>.Parse(quantitiesJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimizedMaximum(n, quantities);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}