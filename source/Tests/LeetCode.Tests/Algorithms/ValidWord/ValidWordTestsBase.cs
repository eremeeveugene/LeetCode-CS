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

using LeetCode.Algorithms.ValidWord;

namespace LeetCode.Tests.Algorithms.ValidWord;

public abstract class ValidWordTestsBase<T> where T : IValidWord, new()
{
    [TestMethod]
    [DataRow("234Adas", true)]
    [DataRow("b3", false)]
    [DataRow("a3$e", false)]
    [DataRow("AhI", true)]
    public void IsValid_WithGivenWord_ReturnsWhetherItMeetsCriteria(string word, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsValid(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}