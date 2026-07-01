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

using LeetCode.Algorithms.CanPlaceFlowers;

namespace LeetCode.Tests.Algorithms.CanPlaceFlowers;

public abstract class CanPlaceFlowersTestsBase<T> where T : ICanPlaceFlowers, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 0, 0, 1 }, 1, true)]
    [DataRow(new[] { 1, 0, 0, 0, 1 }, 2, false)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 1, true)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 2, true)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 3, true)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 4, false)]
    [DataRow(new[] { 0 }, 1, true)]
    [DataRow(new[] { 0 }, 0, true)]
    [DataRow(new[] { 1 }, 0, true)]
    [DataRow(new[] { 1 }, 1, false)]
    [DataRow(new[] { 0, 0 }, 1, true)]
    [DataRow(new[] { 0, 0 }, 2, false)]
    [DataRow(new[] { 1, 0 }, 1, false)]
    [DataRow(new[] { 0, 1 }, 1, false)]
    [DataRow(new[] { 0, 0, 1, 0, 0 }, 1, true)]
    [DataRow(new[] { 0, 0, 1, 0, 0 }, 2, true)]
    [DataRow(new[] { 0, 0, 1, 0, 0 }, 3, false)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 0, 1 }, 2, true)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 0, 1 }, 3, false)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0 }, 4, true)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0 }, 5, false)]
    [DataRow(new[] { 0, 0, 1, 0, 1, 0, 0 }, 2, true)]
    [DataRow(new[] { 0, 0, 1, 0, 1, 0, 0 }, 3, false)]
    [DataRow(new[] { 0, 0, 0, 1, 0, 0, 0 }, 2, true)]
    [DataRow(new[] { 0, 0, 0, 1, 0, 0, 0 }, 3, false)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 1 }, 0, true)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 1 }, 1, false)]
    [DataRow(new[] { 0, 0, 0 }, 2, true)]
    [DataRow(new[] { 0, 0, 0 }, 3, false)]
    public void CanPlaceFlowers_WithFlowerbedAndFlowerCount_ReturnsWhetherFlowersCanBePlanted(int[] flowerbed, int flower, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanPlaceFlowers(flowerbed, flower);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}