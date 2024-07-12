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

using LeetCode.Algorithms.ValidAnagram;

namespace LeetCode.Tests.Algorithms.ValidAnagram;

public abstract class ValidAnagramTestsBase<T> where T : IValidAnagram, new()
{
    [TestMethod]
    [DataRow("ab", "a", false)]
    [DataRow("rat", "car", false)]
    [DataRow("anagram", "nagaram", true)]
    public void IsAnagram_WithGivenStrings_ReturnsIfStringsAreAnagrams(string s, string t, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsAnagram(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}