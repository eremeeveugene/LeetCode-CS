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

using LeetCode.Algorithms.FindTheDifference;

namespace LeetCode.Tests.Algorithms.FindTheDifference;

public abstract class FindTheDifferenceTestsBase<T> where T : IFindTheDifference, new()
{
    [TestMethod]
    [DataRow("abcd", "abcde", 'e')]
    [DataRow("", "y", 'y')]
    [DataRow("a", "aa", 'a')]
    public void FindTheDifference_WithTwoStrings_ReturnsExtraCharacter(string s, string t, char expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindTheDifference(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}