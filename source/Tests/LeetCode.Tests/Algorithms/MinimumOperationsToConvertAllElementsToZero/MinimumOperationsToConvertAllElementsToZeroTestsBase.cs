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

using LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToConvertAllElementsToZero;

public abstract class MinimumOperationsToConvertAllElementsToZeroTestsBase<T>
    where T : IMinimumOperationsToConvertAllElementsToZero, new()
{
    [TestMethod]
    [DataRow("[0,2]", 1)]
    [DataRow("[3,1,2,1]", 3)]
    [DataRow("[1,2,1,2,1,2]", 4)]
    public void MinOperations_WithNumsArray_ReturnsMinimumOperationsToZeroAllElements(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}