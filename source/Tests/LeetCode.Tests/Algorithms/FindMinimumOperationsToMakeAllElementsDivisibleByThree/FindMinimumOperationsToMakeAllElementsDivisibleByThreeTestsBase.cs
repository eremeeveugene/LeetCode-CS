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

using LeetCode.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;

public abstract class FindMinimumOperationsToMakeAllElementsDivisibleByThreeTestsBase<T>
    where T : IFindMinimumOperationsToMakeAllElementsDivisibleByThree, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3, 4]", 3)]
    [DataRow("[3, 6, 9]", 0)]
    public void MinimumOperations_WithGivenNums_ReturnsMinimumOperationsCount(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}