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

using LeetCode.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

namespace LeetCode.Tests.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

public abstract class MinimumStringLengthAfterRemovingSubstringsTestsBase<T>
    where T : IMinimumStringLengthAfterRemovingSubstrings, new()
{
    [TestMethod]
    [DataRow("ABFCACDB", 2)]
    [DataRow("ACBBD", 5)]
    public void MinLength_GivenString_ReturnsMinimumLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}