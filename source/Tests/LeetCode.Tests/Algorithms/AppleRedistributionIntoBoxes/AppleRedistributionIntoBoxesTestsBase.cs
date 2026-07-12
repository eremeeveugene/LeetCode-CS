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