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

using LeetCode.Algorithms.RotateString;

namespace LeetCode.Tests.Algorithms.RotateString;

public abstract class RotateStringTestsBase<T> where T : IRotateString, new()
{
    [TestMethod]
    [DataRow("abcde", "abcde", true)]
    [DataRow("abcde", "abced", false)]
    public void RotateString_WithOriginalAndGoalStrings_ReturnsIfRotationExists(string s, string goal,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RotateString(s, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}