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

using LeetCode.Algorithms.MakeSumDivisibleByP;

namespace LeetCode.Tests.Algorithms.MakeSumDivisibleByP;

public abstract class MakeSumDivisibleByPTestsBase<T> where T : IMakeSumDivisibleByP, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 4, 2 }, 6, 1)]
    [DataRow(new[] { 6, 3, 5, 2 }, 9, 2)]
    [DataRow(new[] { 1, 2, 3 }, 3, 0)]
    public void MinSubarray_WithArrayAndDivisor_ReturnsMinSubarrayToRemove(int[] nums, int p, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSubarray(nums, p);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}