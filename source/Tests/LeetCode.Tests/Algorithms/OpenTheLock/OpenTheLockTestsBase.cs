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

using LeetCode.Algorithms.OpenTheLock;

namespace LeetCode.Tests.Algorithms.OpenTheLock;

public abstract class OpenTheLockTestsBase<T> where T : IOpenTheLock, new()
{
    [TestMethod]
    [DataRow(new[] { "0000" }, "8888", -1)]
    [DataRow(new[] { "0201", "0101", "0102", "1212", "2002" }, "0202", 6)]
    [DataRow(new[] { "8888" }, "0009", 1)]
    [DataRow(new[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }, "8888", -1)]
    public void OpenLock_GivenDeadendsAndTarget_ReturnsMinimumTurnsOrMinusOne(string[] deadends, string target,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.OpenLock(deadends, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}