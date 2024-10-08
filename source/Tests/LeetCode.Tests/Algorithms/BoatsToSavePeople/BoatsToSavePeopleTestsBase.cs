﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.BoatsToSavePeople;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BoatsToSavePeople;

public abstract class BoatsToSavePeopleTestsBase<T> where T : IBoatsToSavePeople, new()
{
    [TestMethod]
    [DataRow("[1, 2]", 3, 1)]
    [DataRow("[3, 2, 2, 1]", 3, 3)]
    [DataRow("[3, 5, 3, 4]", 5, 4)]
    [DataRow("[11, 2, 8, 1]", 11, 3)]
    [DataRow("[11, 2, 2, 8, 8]", 11, 3)]
    [DataRow("[3, 2, 3, 2, 2]", 6, 3)]
    public void NumRescueBoats_GivenPeopleAndLimit_ReturnsExpectedNumberOfBoats(string peopleJsonArray, int limit,
        int expectedResult)
    {
        // Arrange
        var people = JsonHelper<int>.DeserializeToArray(peopleJsonArray);
        var solution = new T();

        // Act
        var actualResult = solution.NumRescueBoats(people, limit);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}