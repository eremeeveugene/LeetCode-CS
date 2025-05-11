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

using LeetCode.Algorithms.MinimumCostToReachEveryPosition;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumCostToReachEveryPosition;

public abstract class MinimumCostToReachEveryPositionTestsBase<T> where T : IMinimumCostToReachEveryPosition, new()
{
    [TestMethod]
    [DataRow("[5,3,4,1,3,2]", "[5,3,3,1,1,1]")]
    [DataRow("[1,2,4,6,7]", "[1,1,1,1,1]")]
    public void MinCosts_WithCostArray_ReturnsMinimumCostAtEachStep(string costJson,
        string expectedResultJson)
    {
        // Arrange
        var cost = JsonHelper<int[]>.Parse(costJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinCosts(cost);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}