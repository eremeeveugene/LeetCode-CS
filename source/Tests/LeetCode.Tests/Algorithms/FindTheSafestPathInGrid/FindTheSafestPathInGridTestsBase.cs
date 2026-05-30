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

using LeetCode.Algorithms.FindTheSafestPathInGrid;

namespace LeetCode.Tests.Algorithms.FindTheSafestPathInGrid;

public abstract class FindTheSafestPathInGridTestsBase<T> where T : IFindTheSafestPathInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumSafenessFactor_WithGridInput_ReturnsSafenessFactorForPath(IList<IList<int>> grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSafenessFactor(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new IList<int>[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, 0];

        yield return [new IList<int>[] { new[] { 0, 0, 1 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 2];

        yield return [new IList<int>[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 0, 0 } }, 2];
    }
}