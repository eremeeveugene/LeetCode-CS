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

using LeetCode.Algorithms.LongestHarmoniousSubsequence;

namespace LeetCode.Tests.Algorithms.LongestHarmoniousSubsequence;

public abstract class LongestHarmoniousSubsequenceTestsBase<T> where T : ILongestHarmoniousSubsequence, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 2, 5, 2, 3, 7 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0)]
    public void FindLHS_WithNumsArray_ReturnsLongestHarmoniousSubsequenceLength(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLHS(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}