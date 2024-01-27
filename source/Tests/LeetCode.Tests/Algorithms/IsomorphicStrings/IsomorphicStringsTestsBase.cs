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

using LeetCode.Algorithms.IsomorphicStrings;

namespace LeetCode.Tests.Algorithms.IsomorphicStrings;

public abstract class IsomorphicStringsTestsBase<T> where T : IIsomorphicStrings, new()
{
    [TestMethod]
    [DataRow("egg", "add", true)]
    [DataRow("foo", "bar", false)]
    [DataRow("paper", "title", true)]
    [DataRow("badc", "baba", false)]
    public void IsIsomorphic_WithTwoStrings_ReturnsExpectedBoolean(string s, string t, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsIsomorphic(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}