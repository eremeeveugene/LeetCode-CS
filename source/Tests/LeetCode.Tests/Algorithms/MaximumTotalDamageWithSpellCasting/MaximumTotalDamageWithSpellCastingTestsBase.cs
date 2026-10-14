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

using LeetCode.Algorithms.MaximumTotalDamageWithSpellCasting;

namespace LeetCode.Tests.Algorithms.MaximumTotalDamageWithSpellCasting;

public abstract class MaximumTotalDamageWithSpellCastingTestsBase<T> where T : IMaximumTotalDamageWithSpellCasting, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 3, 4 }, 6L)]
    [DataRow(new[] { 7, 1, 6, 6 }, 13L)]
    [DataRow(new[] { 1 }, 1L)]
    [DataRow(new[] { 1000000000 }, 1000000000L)]
    [DataRow(new[] { 5, 5, 5 }, 15L)]
    [DataRow(new[] { 1, 2 }, 2L)]
    [DataRow(new[] { 1, 3 }, 3L)]
    [DataRow(new[] { 1, 4 }, 5L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 7L)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }, 9L)]
    [DataRow(new[] { 2, 4, 6, 8 }, 12L)]
    [DataRow(new[] { 10, 10, 12, 12, 14 }, 34L)]
    [DataRow(new[] { 1000000000, 999999999, 999999998, 999999997 }, 1999999997L)]
    [DataRow(new[] { 1, 10, 100, 1000 }, 1111L)]
    [DataRow(new[] { 3, 3, 5, 5, 7, 7, 9 }, 20L)]
    [DataRow(new[] { 4, 4, 4, 4, 1 }, 17L)]
    [DataRow(new[] { 1, 5, 9, 13, 17 }, 45L)]
    [DataRow(new[] { 2, 3, 4, 5, 6, 7 }, 11L)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000 }, 3000000000L)]
    [DataRow(new[] { 8, 6, 4, 2, 1, 3, 5, 7 }, 15L)]
    public void MaximumTotalDamage_WithPowerValues_ReturnsMaximumAchievableDamage(int[] power, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumTotalDamage(power);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}