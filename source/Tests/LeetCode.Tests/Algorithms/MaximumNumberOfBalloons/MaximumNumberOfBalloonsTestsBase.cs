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

using LeetCode.Algorithms.MaximumNumberOfBalloons;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfBalloons;

public abstract class MaximumNumberOfBalloonsTestsBase<T> where T : IMaximumNumberOfBalloons, new()
{
    [TestMethod]
    [DataRow("nlaebolko", 1)]
    [DataRow("loonbalxballpoon", 2)]
    [DataRow("leetcode", 0)]
    [DataRow("balloon", 1)]
    [DataRow("balloonballoon", 2)]
    [DataRow("balon", 0)]
    [DataRow("ballon", 0)]
    [DataRow("balloo", 0)]
    [DataRow("alloon", 0)]
    [DataRow("", 0)]
    [DataRow("b", 0)]
    [DataRow("aaaaaaa", 0)]
    [DataRow("balloonba", 1)]
    [DataRow("bbaalllloooonn", 2)]
    [DataRow("bbaallllooooonnn", 2)]
    [DataRow("bbbaaaallllllooooooonnn", 3)]
    [DataRow("balloonballoonballoon", 3)]
    [DataRow("oonllab", 1)]
    [DataRow("balllllooooon", 1)]
    [DataRow("balloonn", 1)]
    [DataRow("baolln", 0)]
    [DataRow("ballloon", 1)]
    public void MaxNumberOfBalloons_WithText_ReturnsMaximumInstances(string text, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxNumberOfBalloons(text);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}