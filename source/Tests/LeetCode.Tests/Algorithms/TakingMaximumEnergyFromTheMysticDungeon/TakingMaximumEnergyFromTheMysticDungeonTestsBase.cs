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

using LeetCode.Algorithms.TakingMaximumEnergyFromTheMysticDungeon;

namespace LeetCode.Tests.Algorithms.TakingMaximumEnergyFromTheMysticDungeon;

public abstract class TakingMaximumEnergyFromTheMysticDungeonTestsBase<T> where T : ITakingMaximumEnergyFromTheMysticDungeon, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, -10, -5, 1 }, 3, 3)]
    [DataRow(new[] { -2, -3, -1 }, 2, -1)]
    [DataRow(new[] { 5 }, 1, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 15)]
    [DataRow(new[] { 1, -1 }, 1, 0)]
    [DataRow(new[] { -1, -1, -1 }, 1, -1)]
    [DataRow(new[] { 0, 0, 0 }, 1, 0)]
    [DataRow(new[] { 10, -5, 10, -5, 10 }, 2, 30)]
    [DataRow(new[] { 100, -100 }, 1, 0)]
    [DataRow(new[] { -100, 100 }, 1, 100)]
    [DataRow(new[] { 1, 2, 3 }, 3, 3)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 4)]
    [DataRow(new[] { -5 }, 1, -5)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 2, 15)]
    [DataRow(new[] { 3, -1, 4, -1, 5, -9, 2, 6 }, 3, 11)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 6, 1)]
    [DataRow(new[] { 2, 4, 6, 8 }, 2, 12)]
    [DataRow(new[] { -1, -2, -3, -4 }, 2, -3)]
    [DataRow(new[] { 0 }, 1, 0)]
    [DataRow(new[] { 7, -3, 7, -3, 7, -3, 7 }, 1, 19)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 15)]
    [DataRow(new[] { -1, -2, -3, -4, -5, -6 }, 3, -4)]
    public void MaximumEnergy_WithEnergyAndK_ReturnsMaximumEnergy(int[] energies, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumEnergy(energies, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}