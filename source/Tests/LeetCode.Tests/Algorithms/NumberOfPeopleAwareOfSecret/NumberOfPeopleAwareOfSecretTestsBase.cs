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
    public void PeopleAwareOfSecret_WithDelayAndForgetPeriods_ReturnsTotalPeopleKnowingSecretAtEndOfDay(int n,
        int delay, int forget, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PeopleAwareOfSecret(n, delay, forget);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}