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

using LeetCode.Algorithms.ApplyOperationsToAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ApplyOperationsToAnArray;

public abstract class ApplyOperationsToAnArrayTestsBase<T> where T : IApplyOperationsToAnArray, new()
{
    [TestMethod]
    [DataRow("[0,1]", "[1,0]")]
    [DataRow("[1,2,2,1,1,0]", "[1,4,2,0,0,0]")]
    public void ApplyOperations_WithGivenNumbersArray_ReturnsTransformedArray(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ApplyOperations(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}