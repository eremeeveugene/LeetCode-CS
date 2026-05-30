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

using LeetCode.Algorithms.SolvingQuestionsWithBrainpower;

namespace LeetCode.Tests.Algorithms.SolvingQuestionsWithBrainpower;

public abstract class SolvingQuestionsWithBrainpowerTestsBase<T> where T : ISolvingQuestionsWithBrainpower, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MostPoints_GivenQuestionsArray_ReturnsMaximumPoints(int[][] questions, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MostPoints(questions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 2 }, new[] { 4, 3 }, new[] { 4, 4 }, new[] { 2, 5 } }, 5L];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 }, new[] { 5, 5 } }, 7L];
    }
}