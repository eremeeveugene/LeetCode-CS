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

using LeetCode.Algorithms.DivisibleAndNonDivisibleSumsDifference;

namespace LeetCode.Tests.Algorithms.DivisibleAndNonDivisibleSumsDifference;

public abstract class DivisibleAndNonDivisibleSumsDifferenceTestsBase<T>
    where T : IDivisibleAndNonDivisibleSumsDifference, new()
{
    [TestMethod]
    [DataRow(10, 3, 19)]
    [DataRow(5, 6, 15)]
    [DataRow(5, 1, -15)]
    public void DifferenceOfSums_GivenNAndM_ReturnsExpectedDifference(int n, int m, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DifferenceOfSums(n, m);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}