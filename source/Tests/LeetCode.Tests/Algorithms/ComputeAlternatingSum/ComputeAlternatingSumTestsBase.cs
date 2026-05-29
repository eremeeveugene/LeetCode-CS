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

using LeetCode.Algorithms.ComputeAlternatingSum;

namespace LeetCode.Tests.Algorithms.ComputeAlternatingSum;

public abstract class ComputeAlternatingSumTestsBase<T> where T : IComputeAlternatingSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 7 }, -4)]
    [DataRow(new[] { 100 }, 100)]
    public void AlternatingSum_WithNumsArray_ReturnsAlternatingIndexedSum(int[] nums,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AlternatingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}