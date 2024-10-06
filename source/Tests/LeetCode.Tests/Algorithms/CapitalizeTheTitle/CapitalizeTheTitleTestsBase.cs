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

using LeetCode.Algorithms.CapitalizeTheTitle;

namespace LeetCode.Tests.Algorithms.CapitalizeTheTitle;

public abstract class CapitalizeTheTitleTestsBase<T> where T : ICapitalizeTheTitle, new()
{
    [TestMethod]
    [DataRow("capiTalIze tHe titLe", "Capitalize The Title")]
    [DataRow("First leTTeR of EACH Word", "First Letter of Each Word")]
    [DataRow("i lOve leetcode", "i Love Leetcode")]
    public void CapitalizeTitle_GivenTitle_ReturnsCorrectlyCapitalizedTitle(string title, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CapitalizeTitle(title);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}