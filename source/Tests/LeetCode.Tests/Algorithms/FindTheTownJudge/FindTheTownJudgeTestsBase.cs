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

using LeetCode.Algorithms.FindTheTownJudge;

namespace LeetCode.Tests.Algorithms.FindTheTownJudge;

public abstract class FindTheTownJudgeTestsBase<T> where T : IFindTheTownJudge, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindJudge_WithTrustMatrix_ReturnsJudgeLabelOrMinusOne(int n, int[][] trust, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindJudge(n, trust);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [1, Array.Empty<int[]>(), 1];

        yield return [2, Array.Empty<int[]>(), -1];

        yield return [2, new[] { new[] { 1, 2 } }, 2];

        yield return [3, new[] { new[] { 1, 3 }, new[] { 2, 3 } }, 3];

        yield return [3, new[] { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 1 } }, -1];
    }
}