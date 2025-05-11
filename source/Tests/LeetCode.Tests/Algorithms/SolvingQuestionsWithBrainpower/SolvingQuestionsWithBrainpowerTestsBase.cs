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

using LeetCode.Algorithms.SolvingQuestionsWithBrainpower;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SolvingQuestionsWithBrainpower;

public abstract class SolvingQuestionsWithBrainpowerTestsBase<T> where T : ISolvingQuestionsWithBrainpower, new()
{
    [TestMethod]
    [DataRow("[[3,2],[4,3],[4,4],[2,5]]", 5)]
    [DataRow("[[1,1],[2,2],[3,3],[4,4],[5,5]]", 7)]
    public void MostPoints_GivenQuestionsArray_ReturnsMaximumPoints(string questionsJson, long expectedResult)
    {
        // Arrange
        var questions = JsonHelper<int[][]>.Parse(questionsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MostPoints(questions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}