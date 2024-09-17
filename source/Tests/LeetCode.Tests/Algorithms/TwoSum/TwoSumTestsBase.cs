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

using LeetCode.Algorithms.TwoSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TwoSum;

public abstract class TwoSumTestsBase<T> where T : ITwoSum, new()
{
    [TestMethod]
    [DataRow("[2, 7, 11, 15]", 9, "[0, 1]")]
    [DataRow("[3, 2, 4]", 6, "[1, 2]")]
    [DataRow("[3, 3]", 6, "[0, 1]")]
    [DataRow("[2, 5, 5, 11]", 10, "[1, 2]")]
    public void TwoSum_WithIntArrayAndTarget_ReturnsIndicesOfNumbersAddingToTarget(string numsJsonArray, int target,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.TwoSum(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}