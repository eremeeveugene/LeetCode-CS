// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

namespace LeetCode.Tests.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

public abstract class CheckIfOneStringSwapCanMakeStringsEqualTestsBase<T>
    where T : ICheckIfOneStringSwapCanMakeStringsEqual, new()
{
    [TestMethod]
    [DataRow("bank", "kanb", true)]
    [DataRow("attack", "defend", false)]
    [DataRow("kelb", "kelb", true)]
    public void AreAlmostEqual_WithTwoStrings_ReturnsIfTheyCanBeMadeEqualByOneSwap(string s1, string s2,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AreAlmostEqual(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}