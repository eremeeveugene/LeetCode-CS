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

using LeetCode.Algorithms.GenerateTagForVideoCaption;

namespace LeetCode.Tests.Algorithms.GenerateTagForVideoCaption;

public abstract class GenerateTagForVideoCaptionTestsBase<T> where T : IGenerateTagForVideoCaption, new()
{
    [TestMethod]
    [DataRow("Leetcode daily streak achieved", "#leetcodeDailyStreakAchieved")]
    [DataRow("can I Go There", "#canIGoThere")]
    [DataRow("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh", "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh")]
    [DataRow("hello", "#hello")]
    [DataRow("Hello World", "#helloWorld")]
    [DataRow("a b c", "#aBC")]
    [DataRow("one two three four", "#oneTwoThreeFour")]
    [DataRow("HELLO WORLD", "#helloWorld")]
    [DataRow("abc def ghi", "#abcDefGhi")]
    [DataRow("My First Tag", "#myFirstTag")]
    [DataRow("already camelCase tag", "#alreadyCamelcaseTag")]
    [DataRow("x y z", "#xYZ")]
    [DataRow("single", "#single")]
    [DataRow("two words", "#twoWords")]
    [DataRow("ALL CAPS HERE", "#allCapsHere")]
    [DataRow("mixed CASE words here", "#mixedCaseWordsHere")]
    [DataRow("a", "#a")]
    [DataRow("Hello Claude Code", "#helloClaudeCode")]
    [DataRow("open source project", "#openSourceProject")]
    [DataRow("UPPER CASE INPUT", "#upperCaseInput")]
    public void GenerateTag_WithCaptionContainingMultipleWords_ReturnsCamelCaseHashTag(string caption, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GenerateTag(caption);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}