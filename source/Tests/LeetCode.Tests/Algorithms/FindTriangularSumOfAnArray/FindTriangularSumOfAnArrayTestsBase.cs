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

using LeetCode.Algorithms.FindTriangularSumOfAnArray;

namespace LeetCode.Tests.Algorithms.FindTriangularSumOfAnArray;

public abstract class FindTriangularSumOfAnArrayTestsBase<T> where T : IFindTriangularSumOfAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 8)]
    [DataRow(new[] { 5 }, 5)]
    public void TriangularSum_WithNums_ReturnsTriangularSumOfNums(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TriangularSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}