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

using LeetCode.Algorithms.GreatestSumDivisibleByThree;

namespace LeetCode.Tests.Algorithms.GreatestSumDivisibleByThree;

public abstract class GreatestSumDivisibleByThreeTestsBase<T> where T : IGreatestSumDivisibleByThree, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 6, 5, 1, 8 }, 18)]
    [DataRow(new[] { 4 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 4 }, 12)]
    public void MaxSumDivThree_WithNumsArray_ReturnsMaxSumDivisibleByThree(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSumDivThree(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}