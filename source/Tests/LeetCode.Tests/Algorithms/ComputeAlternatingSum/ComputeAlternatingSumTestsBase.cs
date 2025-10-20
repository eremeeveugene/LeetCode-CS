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

using LeetCode.Algorithms.ComputeAlternatingSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ComputeAlternatingSum;

public abstract class ComputeAlternatingSumTestsBase<T> where T : IComputeAlternatingSum, new()
{
    [TestMethod]
    [DataRow("[1,3,5,7]", -4)]
    [DataRow("[100]", 100)]
    public void AlternatingSum_WithNumsArray_ReturnsAlternatingIndexedSum(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.AlternatingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}