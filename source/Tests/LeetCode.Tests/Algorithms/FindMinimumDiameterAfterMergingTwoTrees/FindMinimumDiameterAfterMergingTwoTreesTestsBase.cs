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

using LeetCode.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

namespace LeetCode.Tests.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

public abstract class FindMinimumDiameterAfterMergingTwoTreesTestsBase<T> where T : IFindMinimumDiameterAfterMergingTwoTrees, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumDiameterAfterMerge_WithTwoGraphs_CalculatesMinimumDiameter(int[][] edges1, int[][] edges2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDiameterAfterMerge(edges1, edges2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, new[] { new[] { 0, 1 } }, 3];

        yield return
        [
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 4 }, new[] { 2, 5 }, new[] { 3, 6 }, new[] { 2, 7 } },
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 4 }, new[] { 2, 5 }, new[] { 3, 6 }, new[] { 2, 7 } },
            5
        ];
    }
}