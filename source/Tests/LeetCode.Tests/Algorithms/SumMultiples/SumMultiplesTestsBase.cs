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

using LeetCode.Algorithms.SumMultiples;

namespace LeetCode.Tests.Algorithms.SumMultiples;

public abstract class SumMultiplesTestsBase<T> where T : ISumMultiples, new()
{
    [TestMethod]
    [DataRow(7, 21)]
    [DataRow(10, 40)]
    [DataRow(9, 30)]
    [DataRow(1, 0)]
    [DataRow(2, 0)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    [DataRow(5, 8)]
    [DataRow(6, 14)]
    [DataRow(8, 21)]
    [DataRow(14, 66)]
    [DataRow(15, 81)]
    [DataRow(21, 140)]
    [DataRow(35, 342)]
    [DataRow(100, 2838)]
    [DataRow(105, 3045)]
    [DataRow(210, 12075)]
    [DataRow(500, 67889)]
    [DataRow(999, 271066)]
    [DataRow(1000, 272066)]
    public void SumOfMultiples_GivenNumber_ReturnsSumOfMultiples(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfMultiples(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}