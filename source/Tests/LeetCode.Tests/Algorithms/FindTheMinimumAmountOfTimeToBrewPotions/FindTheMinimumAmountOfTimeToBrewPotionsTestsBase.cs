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

using LeetCode.Algorithms.FindTheMinimumAmountOfTimeToBrewPotions;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAmountOfTimeToBrewPotions;

public abstract class FindTheMinimumAmountOfTimeToBrewPotionsTestsBase<T> where T : IFindTheMinimumAmountOfTimeToBrewPotions, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 5L)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2 }, 21L)]
    [DataRow(new[] { 1, 5, 2, 4 }, new[] { 5, 1, 4, 2 }, 110L)]
    [DataRow(new[] { 1 }, new[] { 1 }, 1L)]
    [DataRow(new[] { 5 }, new[] { 3 }, 15L)]
    [DataRow(new[] { 1 }, new[] { 1, 1, 1 }, 3L)]
    [DataRow(new[] { 2, 3 }, new[] { 1 }, 5L)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, 3L)]
    [DataRow(new[] { 3, 1 }, new[] { 2, 4 }, 22L)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 27L)]
    [DataRow(new[] { 4, 4, 4 }, new[] { 1, 1, 1 }, 20L)]
    [DataRow(new[] { 2, 7, 1 }, new[] { 5 }, 50L)]
    [DataRow(new[] { 1, 9, 1 }, new[] { 9, 1, 9 }, 189L)]
    [DataRow(new[] { 6, 2, 5, 3 }, new[] { 2, 6 }, 108L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2 }, 35L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3 }, 110L)]
    [DataRow(new[] { 10, 1 }, new[] { 1, 10, 1 }, 121L)]
    [DataRow(new[] { 3, 3 }, new[] { 7, 7, 7 }, 84L)]
    [DataRow(new[] { 2, 8, 4 }, new[] { 3, 9, 1, 5 }, 200L)]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 4 }, 16L)]
    public void MinTime_WithSkillsAndManaValues_ReturnsMinimumTotalBrewingTime(int[] wizardSkills, int[] potionMana, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinTime(wizardSkills, potionMana);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}