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

using LeetCode.Algorithms.MaximumAveragePassRatio;

namespace LeetCode.Tests.Algorithms.MaximumAveragePassRatio;

public abstract class MaximumAveragePassRatioTestsBase<T> where T : IMaximumAveragePassRatio, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxAverageRatio_WithClassDataAndExtraStudents_ReturnsMaximumAverageRatio(int[][] classes,
        int extraStudents, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxAverageRatio(classes, extraStudents);

        // Assert
        Assert.AreEqual(expectedResult, Math.Round(actualResult, 5));
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 2, 2 } }, 2, 0.78333];

        yield return [new[] { new[] { 2, 4 }, new[] { 3, 9 }, new[] { 4, 5 }, new[] { 2, 10 } }, 4, 0.53485];
    }
}