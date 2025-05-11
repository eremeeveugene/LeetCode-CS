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

using LeetCode.Algorithms.MinimumNumberOfOperationsToMakeElementsInArrayDistinct;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMakeElementsInArrayDistinct;

public abstract class MinimumNumberOfOperationsToMakeElementsInArrayDistinctTestsBase<T>
    where T : IMinimumNumberOfOperationsToMakeElementsInArrayDistinct, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,2,3,3,5,7]", 2)]
    [DataRow("[4,5,6,4,4]", 2)]
    [DataRow("[6,7,8,9]", 0)]
    public void MinimumOperations_GivenArrayOfNumbers_ReturnsMinimumOperationsCount(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}