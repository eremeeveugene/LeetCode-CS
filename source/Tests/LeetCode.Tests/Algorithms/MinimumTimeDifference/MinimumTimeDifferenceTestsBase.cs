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

using LeetCode.Algorithms.MinimumTimeDifference;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumTimeDifference;

public abstract class MinimumTimeDifferenceTestsBase<T> where T : IMinimumTimeDifference, new()
{
    [TestMethod]
    [DataRow("[\"00:00\",\"23:59\",\"00:00\"]", 0)]
    [DataRow("[\"23:59\",\"00:00\"]", 1)]
    [DataRow("[\"00:00\",\"12:00\"]", 720)]
    [DataRow("[\"23:30\",\"00:10\"]", 40)]
    [DataRow("[\"00:00\",\"12:00\",\"23:59\"]", 1)]
    [DataRow("[\"02:45\",\"11:15\",\"18:30\",\"23:55\"]", 170)]
    [DataRow("[\"00:00\",\"12:34\",\"23:59\",\"03:21\",\"16:45\",\"07:30\",\"20:15\",\"22:22\"]", 1)]
    public void FindMinDifference_GivenTimePoints_ReturnsMinimumDifference(string timePointsJsonArray,
        int expectedResult)
    {
        // Arrange
        var timePoints = JsonHelper<string>.DeserializeToArray(timePointsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMinDifference(timePoints);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}