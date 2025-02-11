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

using LeetCode.Algorithms.RemoveAllOccurrencesOfSubstring;

namespace LeetCode.Tests.Algorithms.RemoveAllOccurrencesOfSubstring;

public abstract class RemoveAllOccurrencesOfSubstringTestsBase<T> where T : IRemoveAllOccurrencesOfSubstring, new()
{
    [TestMethod]
    [DataRow("daabcbaabcbc", "abc", "dab")]
    [DataRow("axxxxyyyyb", "xy", "ab")]
    [DataRow("ixcupqoixcupqokevnpokevnpoknqywmlhevgc", "ixcupqokevnpo", "knqywmlhevgc")]
    public void RemoveOccurrences_GivenStringAndSubstring_RemovesAllOccurrences(string s, string part,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveOccurrences(s, part);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}