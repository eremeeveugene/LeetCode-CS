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

using LeetCode.Algorithms.TwoSum2InputArrayIsSorted;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TwoSum2InputArrayIsSorted;

public abstract class TwoSum2InputArrayIsSortedTestsBase<T> where T : ITwoSum2InputArrayIsSorted, new()
{
    [TestMethod]
    [DataRow("[2,7,11,15]", 9, "[1,2]")]
    [DataRow("[2,3,4]", 6, "[1,3]")]
    [DataRow("[-1,0]", -1, "[1,2]")]
    public void TwoSum_WithSortedArrayAndTargetSum_ReturnsOneIndexedPairAddingToTarget(string numbersJson, int target,
        string expectedResultJson)
    {
        // Arrange
        var numbers = JsonHelper<int[]>.Parse(numbersJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.TwoSum(numbers, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}