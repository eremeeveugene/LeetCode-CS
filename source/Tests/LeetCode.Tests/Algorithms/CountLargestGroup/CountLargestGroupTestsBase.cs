// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountLargestGroup;

namespace LeetCode.Tests.Algorithms.CountLargestGroup;

public abstract class CountLargestGroupTestsBase<T> where T : ICountLargestGroup, new()
{
    [TestMethod]
    [DataRow(2, 2)]
    [DataRow(13, 4)]
    public void CountLargestGroup_WithGivenInteger_ReturnsNumberOfGroupsThatHaveLargestSize(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountLargestGroup(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}