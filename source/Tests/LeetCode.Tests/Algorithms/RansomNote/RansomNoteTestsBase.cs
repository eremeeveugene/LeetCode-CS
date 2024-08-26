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

using LeetCode.Algorithms.RansomNote;

namespace LeetCode.Tests.Algorithms.RansomNote;

public abstract class RansomNoteTestsBase<T> where T : IRansomNote, new()
{
    [TestMethod]
    [DataRow("a", "b", false)]
    [DataRow("aa", "ab", false)]
    [DataRow("aa", "aab", true)]
    public void CanConstruct_WithRansomNoteAndMagazine_ReturnsWhetherConstructIsPossible(string ransomNote,
        string magazine, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}