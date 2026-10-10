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
        yield return [new[] { new[] { 1, 1 } }, 1L];
        yield return [new[] { new[] { 100000, 100000 } }, 100000L];
        yield return [new[] { new[] { 5, 0 }, new[] { 6, 0 } }, 11L];
        yield return [new[] { new[] { 5, 1 }, new[] { 6, 1 }, new[] { 7, 1 } }, 12L];
        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }, 2L];
        yield return [new[] { new[] { 10, 5 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 20, 1 } }, 30L];
        yield return [new[] { new[] { 3, 0 }, new[] { 2, 0 }, new[] { 1, 0 } }, 6L];
        yield return [new[] { new[] { 1, 100000 }, new[] { 2, 100000 }, new[] { 3, 100000 } }, 3L];
        yield return [new[] { new[] { 100000, 1 }, new[] { 100000, 1 }, new[] { 100000, 1 } }, 200000L];
        yield return [new[] { new[] { 2, 2 }, new[] { 5, 1 }, new[] { 4, 0 }, new[] { 3, 3 } }, 8L];
        yield return [new[] { new[] { 7, 1 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 9, 0 } }, 17L];
        yield return [new[] { new[] { 1, 4 }, new[] { 2, 3 }, new[] { 3, 2 }, new[] { 4, 1 }, new[] { 5, 0 } }, 5L];
        yield return [new[] { new[] { 9, 2 }, new[] { 1, 1 }, new[] { 8, 1 }, new[] { 1, 1 }, new[] { 7, 0 } }, 16L];
        yield return [new[] { new[] { 4, 0 } }, 4L];
        yield return [new[] { new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { 1, 0 } }, 8L];
        yield return [new[] { new[] { 50, 3 }, new[] { 40, 1 }, new[] { 30, 1 }, new[] { 20, 0 }, new[] { 100, 0 } }, 160L];
        yield return [new[] { new[] { 6, 2 }, new[] { 7, 0 }, new[] { 8, 0 }, new[] { 9, 1 } }, 24L];
        yield return [BuildQuestions(100000, 100000, 1), 5000000000L];
        yield return [BuildQuestions(100000, 100000, 100000), 100000L];
        yield return [BuildQuestions(100000, 1, 0), 100000L];
    }

    private static int[][] BuildQuestions(int count, int points, int brainpower)
    {
        var questions = new int[count][];

        for (var i = 0; i < count; i++)
        {
            questions[i] = [points, brainpower];
        }

        return questions;
    }
}