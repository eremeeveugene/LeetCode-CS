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

using LeetCode.Algorithms.MinimumCostToReachEveryPosition;

namespace LeetCode.Tests.Algorithms.MinimumCostToReachEveryPosition;

public abstract class MinimumCostToReachEveryPositionTestsBase<T> where T : IMinimumCostToReachEveryPosition, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 4, 1, 3, 2 }, new[] { 5, 3, 3, 1, 1, 1 })]
    [DataRow(new[] { 1, 2, 4, 6, 7 }, new[] { 1, 1, 1, 1, 1 })]
    public void MinCosts_WithCostArray_ReturnsMinimumCostAtEachStep(int[] cost, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCosts(cost);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}