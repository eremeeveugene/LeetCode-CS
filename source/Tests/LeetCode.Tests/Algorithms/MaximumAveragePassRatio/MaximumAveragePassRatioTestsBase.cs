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
    public void MaxAverageRatio_WithClassDataAndExtraStudents_ReturnsMaximumAverageRatio(int[][] classes, int extraStudents, double expectedResult)
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

        yield return [new[] { new[] { 1, 1 } }, 1, 1.0];

        yield return [new[] { new[] { 1, 2 } }, 1, 0.66667];

        yield return [new[] { new[] { 1, 2 } }, 5, 0.85714];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 } }, 0, 0.5];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 } }, 3, 0.70833];

        yield return [new[] { new[] { 1, 10 }, new[] { 9, 10 } }, 5, 0.65];

        yield return [new[] { new[] { 5, 5 }, new[] { 5, 5 } }, 10, 1.0];

        yield return [new[] { new[] { 1, 100 }, new[] { 50, 100 }, new[] { 99, 100 } }, 20, 0.555];

        yield return [new[] { new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 } }, 7, 0.83929];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 3 } }, 4, 0.80556];

        yield return [new[] { new[] { 10, 20 }, new[] { 1, 2 }, new[] { 5, 10 } }, 6, 0.63889];

        yield return [new[] { new[] { 1, 1000 }, new[] { 1, 1000 } }, 1000, 0.334];

        yield return [new[] { new[] { 7, 9 }, new[] { 1, 5 }, new[] { 2, 4 }, new[] { 8, 10 } }, 9, 0.73211];

        yield return [new[] { new[] { 3, 7 }, new[] { 4, 9 }, new[] { 5, 11 } }, 13, 0.62735];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 2, 2 } }, 0, 0.7];

        yield return [new[] { new[] { 100, 200 }, new[] { 1, 300 } }, 50, 0.32288];

        yield return [new[] { new[] { 4, 9 }, new[] { 1, 7 }, new[] { 6, 6 } }, 8, 0.69464];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 5 }, new[] { 3, 5 }, new[] { 4, 5 } }, 3, 0.58214];
    }
}