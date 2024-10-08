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

using LeetCode.Algorithms.FindTheMaximumAchievableNumber;

namespace LeetCode.Tests.Algorithms.FindTheMaximumAchievableNumber;

public abstract class FindTheMaximumAchievableNumberTestsBase<T> where T : IFindTheMaximumAchievableNumber, new()
{
    [TestMethod]
    [DataRow(4, 1, 6)]
    [DataRow(3, 2, 7)]
    public void TheMaximumAchievableX_WithNumAndT_ReturnsExpectedResult(int num, int t, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TheMaximumAchievableX(num, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}