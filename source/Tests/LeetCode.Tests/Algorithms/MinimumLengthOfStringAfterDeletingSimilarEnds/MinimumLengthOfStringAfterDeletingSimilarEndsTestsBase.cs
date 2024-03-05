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

using LeetCode.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

namespace LeetCode.Tests.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

public abstract class MinimumLengthOfStringAfterDeletingSimilarEndsTestsBase<T>
    where T : IMinimumLengthOfStringAfterDeletingSimilarEnds, new()
{
    [TestMethod]
    [DataRow("ca", 2)]
    [DataRow("cabaabac", 0)]
    [DataRow("aabccabba", 3)]
    [DataRow("bbbbbbbbbbbbbbbbbbb", 3)]
    [DataRow(
        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbacccabbabccaccbacaaccacacccaccbbbacaabbccbbcbcbcacacccccccbcbbabccaacaabacbbaccccbabbcbccccaccacaccbcbbcbcccabaaaabbbbbbbbbbbbbbb",
        109)]
    public void MinimumLength_GivenString_ReturnsExpectedMinimumLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}