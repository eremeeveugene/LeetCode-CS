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

using LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;

namespace LeetCode.Tests.Algorithms.CheckIfGridCanBeCutIntoSections;

public abstract class CheckIfGridCanBeCutIntoSectionsTestsBase<T> where T : ICheckIfGridCanBeCutIntoSections, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CheckValidCuts_WithGridSizeAndRectangles_ReturnsWhetherGridCanBeCutIntoSections(int n, int[][] rectangles, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckValidCuts(n, rectangles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 1, 0, 5, 2 }, new[] { 0, 2, 2, 4 }, new[] { 3, 2, 5, 3 }, new[] { 0, 4, 4, 5 } }, true];

        yield return [4, new[] { new[] { 0, 0, 1, 1 }, new[] { 2, 0, 3, 4 }, new[] { 0, 2, 2, 3 }, new[] { 3, 0, 4, 3 } }, true];

        yield return
        [
            4, new[] { new[] { 0, 2, 2, 4 }, new[] { 1, 0, 3, 2 }, new[] { 2, 2, 3, 4 }, new[] { 3, 0, 4, 2 }, new[] { 3, 2, 4, 4 } }, false
        ];

        yield return [3, new[] { new[] { 0, 0, 1, 3 }, new[] { 1, 0, 2, 3 }, new[] { 2, 0, 3, 3 } }, true];

        yield return [3, new[] { new[] { 0, 0, 3, 1 }, new[] { 0, 1, 3, 2 }, new[] { 0, 2, 3, 3 } }, true];

        yield return [4, new[] { new[] { 0, 0, 2, 2 }, new[] { 2, 0, 4, 2 }, new[] { 0, 2, 4, 4 } }, false];

        yield return [3, new[] { new[] { 0, 0, 1, 1 }, new[] { 1, 1, 2, 2 }, new[] { 2, 2, 3, 3 } }, true];

        yield return [4, new[] { new[] { 0, 0, 4, 1 }, new[] { 0, 1, 4, 2 }, new[] { 0, 2, 4, 4 } }, true];

        yield return [5, new[] { new[] { 0, 0, 5, 2 }, new[] { 0, 2, 5, 3 }, new[] { 0, 3, 5, 5 } }, true];

        yield return [5, new[] { new[] { 0, 0, 5, 2 }, new[] { 0, 2, 3, 5 }, new[] { 3, 2, 5, 5 } }, false];

        yield return [6, new[] { new[] { 0, 0, 2, 6 }, new[] { 2, 0, 4, 6 }, new[] { 4, 0, 6, 6 } }, true];

        yield return [6, new[] { new[] { 0, 0, 3, 3 }, new[] { 3, 0, 6, 3 }, new[] { 0, 3, 6, 6 } }, false];

        yield return [6, new[] { new[] { 0, 0, 2, 3 }, new[] { 2, 0, 4, 3 }, new[] { 4, 0, 6, 3 }, new[] { 0, 3, 6, 6 } }, false];

        yield return [10, new[] { new[] { 0, 0, 10, 3 }, new[] { 0, 3, 10, 7 }, new[] { 0, 7, 10, 10 } }, true];

        yield return [10, new[] { new[] { 0, 0, 3, 10 }, new[] { 3, 0, 7, 10 }, new[] { 7, 0, 10, 10 } }, true];

        yield return [10, new[] { new[] { 0, 0, 1, 1 }, new[] { 2, 2, 3, 3 }, new[] { 4, 4, 5, 5 } }, true];

        yield return [10, new[] { new[] { 0, 0, 5, 5 }, new[] { 5, 5, 10, 10 }, new[] { 0, 5, 5, 10 } }, false];

        yield return [7, new[] { new[] { 0, 0, 3, 2 }, new[] { 4, 0, 7, 2 }, new[] { 0, 2, 7, 5 }, new[] { 0, 5, 7, 7 } }, true];

        yield return [7, new[] { new[] { 0, 0, 7, 3 }, new[] { 0, 3, 7, 4 }, new[] { 0, 4, 3, 7 }, new[] { 3, 4, 7, 7 } }, true];

        yield return [4, new[] { new[] { 0, 0, 1, 4 }, new[] { 1, 0, 2, 2 }, new[] { 1, 2, 2, 4 }, new[] { 2, 0, 4, 4 } }, true];
    }
}