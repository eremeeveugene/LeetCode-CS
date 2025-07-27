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

using LeetCode.Algorithms.SetMismatch;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SetMismatch;

public abstract class SetMismatchTestsBase<T> where T : ISetMismatch, new()
{
    [TestMethod]
    [DataRow("[1,2,2,4]", "[2,3]")]
    [DataRow("[1,1]", "[1,2]")]
    public void FindErrorNums_WithDuplicateAndMissingNumberInArray_ReturnsDuplicatedAndMissingNumbers(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindErrorNums(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}