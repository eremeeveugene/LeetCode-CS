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

using LeetCode.Algorithms.CountLargestGroup;

namespace LeetCode.Tests.Algorithms.CountLargestGroup;

public abstract class CountLargestGroupTestsBase<T> where T : ICountLargestGroup, new()
{
    [TestMethod]
    [DataRow(2, 2)]
    [DataRow(13, 4)]
    [DataRow(20, 1)]
    [DataRow(1, 1)]
    [DataRow(3, 3)]
    [DataRow(4, 4)]
    [DataRow(5, 5)]
    [DataRow(6, 6)]
    [DataRow(7, 7)]
    [DataRow(8, 8)]
    [DataRow(9, 9)]
    [DataRow(10, 1)]
    [DataRow(11, 2)]
    [DataRow(12, 3)]
    [DataRow(14, 5)]
    [DataRow(15, 6)]
    [DataRow(16, 7)]
    [DataRow(17, 8)]
    [DataRow(18, 9)]
    [DataRow(19, 9)]
    [DataRow(21, 2)]
    [DataRow(22, 3)]
    [DataRow(24, 5)]
    [DataRow(30, 1)]
    [DataRow(45, 6)]
    [DataRow(50, 1)]
    [DataRow(63, 4)]
    [DataRow(88, 2)]
    [DataRow(99, 1)]
    [DataRow(100, 1)]
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