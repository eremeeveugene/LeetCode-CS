// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfChangesToMakeBinaryStringBeautiful;

public abstract class MinimumNumberOfChangesToMakeBinaryStringBeautifulTestsBase<T>
    where T : IMinimumNumberOfChangesToMakeBinaryStringBeautiful, new()
{
    [TestMethod]
    [DataRow("0000", 0)]
    [DataRow("10", 1)]
    [DataRow("1001", 2)]
    public void MinChanges_GivenBinaryString_ReturnsMinimumChangeCount(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinChanges(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}