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