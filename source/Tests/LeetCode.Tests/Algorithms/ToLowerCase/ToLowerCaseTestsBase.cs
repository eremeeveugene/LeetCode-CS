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

using LeetCode.Algorithms.ToLowerCase;

namespace LeetCode.Tests.Algorithms.ToLowerCase;

public abstract class ToLowerCaseTestsBase<T> where T : IToLowerCase, new()
{
    [TestMethod]
    [DataRow("Hello", "hello")]
    [DataRow("here", "here")]
    [DataRow("LOVELY", "lovely")]
    public void ToLowerCase_GivenStringInput_ReturnsLowercaseString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ToLowerCase(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}