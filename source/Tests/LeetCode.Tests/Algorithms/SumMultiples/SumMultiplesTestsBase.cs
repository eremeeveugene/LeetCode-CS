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

using LeetCode.Algorithms.SumMultiples;

namespace LeetCode.Tests.Algorithms.SumMultiples;

public abstract class SumMultiplesTestsBase<T> where T : ISumMultiples, new()
{
    [TestMethod]
    [DataRow(7, 21)]
    [DataRow(10, 40)]
    [DataRow(9, 30)]
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