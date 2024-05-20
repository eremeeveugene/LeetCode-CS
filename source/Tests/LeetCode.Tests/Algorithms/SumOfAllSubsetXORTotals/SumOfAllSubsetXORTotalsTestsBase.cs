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

using LeetCode.Algorithms.SumOfAllSubsetXORTotals;

namespace LeetCode.Tests.Algorithms.SumOfAllSubsetXORTotals;

public abstract class SumOfAllSubsetXORTotalsTestsBase<T> where T : ISumOfAllSubsetXORTotals, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3 }, 6)]
    [DataRow(new[] { 5, 1, 6 }, 28)]
    [DataRow(new[] { 3, 4, 5, 6, 7, 8 }, 480)]
    public void SubsetXORSum_GivenVariousArrays_ReturnsCorrectXorSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubsetXORSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}