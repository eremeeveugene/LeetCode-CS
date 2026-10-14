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

using LeetCode.Algorithms.AppleRedistributionIntoBoxes;

namespace LeetCode.Tests.Algorithms.AppleRedistributionIntoBoxes;

public abstract class AppleRedistributionIntoBoxesTestsBase<T> where T : IAppleRedistributionIntoBoxes, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2 }, new[] { 4, 3, 1, 5, 2 }, 2)]
    [DataRow(new[] { 5, 5, 5 }, new[] { 2, 4, 2, 7 }, 4)]
    [DataRow(new[] { 1 }, new[] { 1 }, 1)]
    [DataRow(new[] { 1 }, new[] { 5, 1 }, 1)]
    [DataRow(new[] { 5 }, new[] { 3, 3 }, 2)]
    [DataRow(new[] { 5 }, new[] { 3, 2 }, 2)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 3, 1, 1 }, 1)]
    [DataRow(new[] { 10 }, new[] { 4, 3, 2, 1 }, 4)]
    [DataRow(new[] { 10, 10 }, new[] { 10, 10 }, 2)]
    [DataRow(new[] { 2, 3 }, new[] { 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { 2, 3 }, new[] { 1, 1, 1, 1, 5 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5, 5, 1, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 10, 1, 1, 1 }, 1)]
    [DataRow(new[] { 7 }, new[] { 2, 3, 4, 5 }, 2)]
    [DataRow(new[] { 7 }, new[] { 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 3, 3, 3 }, new[] { 4, 4, 4 }, 3)]
    [DataRow(new[] { 50 }, new[] { 50 }, 1)]
    [DataRow(new[] { 50, 50 }, new[] { 50, 50 }, 2)]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 }, 2)]
    [DataRow(new[] { 4, 4 }, new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 6 }, new[] { 1, 1, 1, 1, 1, 1, 1 }, 6)]
    public void MinimumBoxes_WithApplePacksAndBoxCapacities_ReturnsMinimumNumberOfBoxesNeededToStoreAllApples(
        int[] apples,
        int[] capacities,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumBoxes(apples, capacities);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}