// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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