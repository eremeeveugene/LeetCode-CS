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

public abstract class MaximumTotalDamageWithSpellCastingTestsBase<T>
    where T : IMaximumTotalDamageWithSpellCasting, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 3, 4 }, 6L)]
    [DataRow(new[] { 7, 1, 6, 6 }, 13L)]
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