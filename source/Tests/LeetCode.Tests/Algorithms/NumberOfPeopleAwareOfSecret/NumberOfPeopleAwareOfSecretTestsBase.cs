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

using LeetCode.Algorithms.NumberOfPeopleAwareOfSecret;

namespace LeetCode.Tests.Algorithms.NumberOfPeopleAwareOfSecret;

public abstract class NumberOfPeopleAwareOfSecretTestsBase<T> where T : INumberOfPeopleAwareOfSecret, new()
{
    [TestMethod]
    [DataRow(6, 2, 4, 5)]
    [DataRow(4, 1, 3, 6)]
    [DataRow(1, 1, 1, 1)]
    [DataRow(2, 1, 2, 2)]
    [DataRow(3, 1, 2, 2)]
    [DataRow(2, 2, 3, 1)]
    [DataRow(3, 2, 3, 2)]
    [DataRow(4, 2, 3, 1)]
    [DataRow(5, 2, 3, 2)]
    [DataRow(6, 2, 3, 1)]
    [DataRow(5, 1, 3, 10)]
    [DataRow(6, 1, 3, 16)]
    [DataRow(7, 2, 3, 2)]
    [DataRow(8, 2, 3, 1)]
    [DataRow(5, 3, 4, 1)]
    [DataRow(4, 3, 4, 2)]
    [DataRow(3, 3, 4, 1)]
    [DataRow(2, 3, 4, 1)]
    [DataRow(51, 1, 25, 992991676)]
    [DataRow(5, 10, 1, 0)]
    [DataRow(-1, 1, 1, 1)]
    public void PeopleAwareOfSecret_WithDelayAndForgetPeriods_ReturnsTotalPeopleKnowingSecretAtEndOfDay(
        int n,
        int delay,
        int forget,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PeopleAwareOfSecret(n, delay, forget);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}