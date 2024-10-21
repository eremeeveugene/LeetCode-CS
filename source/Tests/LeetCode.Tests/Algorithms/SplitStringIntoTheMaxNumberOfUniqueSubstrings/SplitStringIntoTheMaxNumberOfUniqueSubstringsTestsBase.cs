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

using LeetCode.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

namespace LeetCode.Tests.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

public abstract class SplitStringIntoTheMaxNumberOfUniqueSubstringsTestsBase<T>
    where T : ISplitStringIntoTheMaxNumberOfUniqueSubstrings, new()
{
    [TestMethod]
    [DataRow("ababccc", 5)]
    [DataRow("aba", 2)]
    [DataRow("aa", 1)]
    public void MaxUniqueSplit_GivenString_ReturnsMaxNumberOfUniqueSplits(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxUniqueSplit(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}