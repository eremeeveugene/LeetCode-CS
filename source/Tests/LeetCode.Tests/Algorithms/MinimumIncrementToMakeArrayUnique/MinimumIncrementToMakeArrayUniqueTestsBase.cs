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

using LeetCode.Algorithms.MinimumIncrementToMakeArrayUnique;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumIncrementToMakeArrayUnique;

public abstract class MinimumIncrementToMakeArrayUniqueTestsBase<T>
    where T : IMinimumIncrementToMakeArrayUnique, new()
{
    [TestMethod]
    [DataRow("[0]", 0)]
    [DataRow("[1,2,2]", 1)]
    [DataRow("[3,2,1,2,1,7]", 6)]
    [DataRow("[9,7,6,5,1,0]", 0)]
    [DataRow("[0,0,0,0,0,0,0,0,0,1]", 44)]
    [DataRow("[1,2,3,1,3,2,2,1,3,2,3,1,3,2,1,3,1,2]", 135)]
    public void MinIncrementForUnique_WithVariousArrays_ReturnsExpectedResult(string numsJsonArray, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinIncrementForUnique(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}