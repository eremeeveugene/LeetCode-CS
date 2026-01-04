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

using LeetCode.Algorithms.NumberOfWaysToSplitArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfWaysToSplitArray;

public abstract class NumberOfWaysToSplitArrayTestsBase<T> where T : INumberOfWaysToSplitArray, new()
{
    [TestMethod]
    [DataRow("[10,4,-8,7]", 2)]
    [DataRow("[2,3,1,0]", 2)]
    public void WaysToSplitArray_WithIntegerArray_ReturnsNumberOfValidSplits(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.WaysToSplitArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}