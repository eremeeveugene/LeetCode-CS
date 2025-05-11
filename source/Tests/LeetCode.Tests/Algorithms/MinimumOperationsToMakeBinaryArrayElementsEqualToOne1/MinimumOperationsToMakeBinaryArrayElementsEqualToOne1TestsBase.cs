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

using LeetCode.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeBinaryArrayElementsEqualToOne1;

public abstract class MinimumOperationsToMakeBinaryArrayElementsEqualToOne1TestsBase<T>
    where T : IMinimumOperationsToMakeBinaryArrayElementsEqualToOne1, new()
{
    [TestMethod]
    [DataRow("[0,1,1,1,0,0]", 3)]
    [DataRow("[0,1,1,1]", -1)]
    [DataRow("[1,0,0,1,1,0,1,1,1]", -1)]
    public void MinOperations_WithBinaryArray_ReturnsMinimumOperationsOrMinusOne(string numsJson,
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