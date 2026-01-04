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

using LeetCode.Algorithms.LeftAndRightSumDifferences;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LeftAndRightSumDifferences;

public abstract class LeftAndRightSumDifferencesTestsBase<T> where T : ILeftAndRightSumDifferences, new()
{
    [TestMethod]
    [DataRow("[1]", "[0]")]
    [DataRow("[10, 4, 8, 3]", "[15, 1, 11, 22]")]
    public void LeftRightDifference_WithInputArray_ReturnsAbsoluteLeftRightSums(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.LeftRightDifference(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}