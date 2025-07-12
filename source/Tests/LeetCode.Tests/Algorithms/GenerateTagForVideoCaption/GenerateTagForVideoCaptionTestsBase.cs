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

using LeetCode.Algorithms.GenerateTagForVideoCaption;

namespace LeetCode.Tests.Algorithms.GenerateTagForVideoCaption;

public abstract class GenerateTagForVideoCaptionTestsBase<T> where T : IGenerateTagForVideoCaption, new()
{
    [TestMethod]
    [DataRow("Leetcode daily streak achieved", "#leetcodeDailyStreakAchieved")]
    [DataRow("can I Go There", "#canIGoThere")]
    [DataRow("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh",
        "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh")]
    public void GenerateTag_WithCaptionContainingMultipleWords_ReturnsCamelCaseHashTag(string caption,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GenerateTag(caption);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}