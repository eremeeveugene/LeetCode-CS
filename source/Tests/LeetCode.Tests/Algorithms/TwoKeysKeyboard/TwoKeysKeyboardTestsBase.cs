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

using LeetCode.Algorithms.TwoKeysKeyboard;

namespace LeetCode.Tests.Algorithms.TwoKeysKeyboard;

public abstract class TwoKeysKeyboardTestsBase<T> where T : ITwoKeysKeyboard, new()
{
    [TestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 4)]
    [DataRow(5, 5)]
    [DataRow(6, 5)]
    [DataRow(7, 7)]
    [DataRow(8, 6)]
    [DataRow(9, 6)]
    [DataRow(10, 7)]
    [DataRow(69, 26)]
    [DataRow(128, 14)]
    [DataRow(267, 92)]
    [DataRow(677, 677)]
    [DataRow(821, 821)]
    [DataRow(1000, 21)]
    public void MinSteps_WithInputN_ReturnsMinimumSteps(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSteps(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}