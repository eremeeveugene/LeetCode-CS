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

using LeetCode.Algorithms.FindTheMaximumAchievableNumber;

namespace LeetCode.Tests.Algorithms.FindTheMaximumAchievableNumber;

public abstract class FindTheMaximumAchievableNumberTestsBase<T> where T : IFindTheMaximumAchievableNumber, new()
{
    [TestMethod]
    [DataRow(4, 1, 6)]
    [DataRow(3, 2, 7)]
    [DataRow(1, 1, 3)]
    [DataRow(1, 50, 101)]
    [DataRow(50, 1, 52)]
    [DataRow(50, 50, 150)]
    [DataRow(10, 5, 20)]
    [DataRow(25, 25, 75)]
    [DataRow(7, 3, 13)]
    [DataRow(2, 10, 22)]
    [DataRow(33, 17, 67)]
    [DataRow(15, 2, 19)]
    [DataRow(40, 8, 56)]
    [DataRow(5, 5, 15)]
    [DataRow(49, 49, 147)]
    [DataRow(3, 1, 5)]
    [DataRow(20, 20, 60)]
    [DataRow(12, 30, 72)]
    [DataRow(1, 2, 5)]
    [DataRow(8, 4, 16)]
    public void TheMaximumAchievableX_WithStartValueAndSteps_ReturnsMaxValueByIncrementingOrDecrementing(int num, int t, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TheMaximumAchievableX(num, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}