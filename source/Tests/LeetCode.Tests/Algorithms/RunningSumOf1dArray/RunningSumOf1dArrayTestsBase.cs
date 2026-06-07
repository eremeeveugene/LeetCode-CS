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

using LeetCode.Algorithms.RunningSumOf1dArray;

namespace LeetCode.Tests.Algorithms.RunningSumOf1dArray;

public abstract class RunningSumOf1dArrayTestsBase<T> where T : IRunningSumOf1dArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { -1 }, new[] { -1 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { -1, -2, -3 }, new[] { -1, -3, -6 })]
    [DataRow(new[] { -1, 2, -3 }, new[] { -1, 1, -2 })]
    [DataRow(new[] { 10, 20 }, new[] { 10, 30 })]
    [DataRow(new[] { 0, 1, 0, 1 }, new[] { 0, 1, 1, 2 })]
    [DataRow(new[] { 100, 200, 300 }, new[] { 100, 300, 600 })]
    [DataRow(new[] { 1, 0, 2, 0, 3 }, new[] { 1, 1, 3, 3, 6 })]
    [DataRow(new[] { 5, 5, 5, 5 }, new[] { 5, 10, 15, 20 })]
    [DataRow(new[] { -5, 5, -5, 5 }, new[] { -5, 0, -5, 0 })]
    [DataRow(new[] { 1000, 2000, 3000, 4000 }, new[] { 1000, 3000, 6000, 10000 })]
    [DataRow(new[] { 2, 4 }, new[] { 2, 6 })]
    public void RunningSum_GivenArrays_ReturnsCumulativeSumsPerElement(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RunningSum(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}