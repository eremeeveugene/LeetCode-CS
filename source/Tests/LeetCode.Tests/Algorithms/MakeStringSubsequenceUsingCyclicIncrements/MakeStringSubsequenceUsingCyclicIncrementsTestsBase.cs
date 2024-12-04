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

using LeetCode.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

namespace LeetCode.Tests.Algorithms.MakeStringSubsequenceUsingCyclicIncrements;

public abstract class MakeStringSubsequenceUsingCyclicIncrementsTestsBase<T>
    where T : IMakeStringSubsequenceUsingCyclicIncrements, new()
{
    [TestMethod]
    [DataRow("abc", "ad", true)]
    [DataRow("zc", "ad", true)]
    [DataRow("ab", "d", false)]
    public void CanMakeSubsequence_WithGivenStrings_ReturnsTrueIfPossible(string str1, string str2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanMakeSubsequence(str1, str2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}