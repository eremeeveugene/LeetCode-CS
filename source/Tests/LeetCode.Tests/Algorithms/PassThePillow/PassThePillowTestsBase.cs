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

using LeetCode.Algorithms.PassThePillow;

namespace LeetCode.Tests.Algorithms.PassThePillow;

public abstract class PassThePillowTestsBase<T> where T : IPassThePillow, new()
{
    [TestMethod]
    [DataRow(4, 5, 2)]
    [DataRow(3, 2, 3)]
    [DataRow(3, 100, 1)]
    [DataRow(23, 967, 2)]
    [DataRow(23, 967, 2)]
    [DataRow(10, 999, 10)]
    [DataRow(18, 38, 5)]
    [DataRow(2, 1000, 1)]
    public void PassThePillow_WithNumberOfPeopleAndTime_ReturnsCorrectPosition(int n, int time, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PassThePillow(n, time);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}