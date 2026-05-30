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

using LeetCode.Algorithms.MinimumDeletionsToMakeStringKSpecial;

namespace LeetCode.Tests.Algorithms.MinimumDeletionsToMakeStringKSpecial;

public abstract class MinimumDeletionsToMakeStringKSpecialTestsBase<T> where T : IMinimumDeletionsToMakeStringKSpecial, new()
{
    [TestMethod]
    [DataRow("aabcaba", 0, 3)]
    [DataRow("aaabaaa", 2, 1)]
    [DataRow("dabdcbdcdcd", 2, 2)]
    public void MinimumDeletions_WithWordAndValueK_ReturnsMinimumDeletionsToMakeKSpecial(string word, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDeletions(word, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}