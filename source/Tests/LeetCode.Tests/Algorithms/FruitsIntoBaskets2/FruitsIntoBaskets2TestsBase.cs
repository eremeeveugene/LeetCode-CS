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

using LeetCode.Algorithms.FruitsIntoBaskets2;

namespace LeetCode.Tests.Algorithms.FruitsIntoBaskets2;

public abstract class FruitsIntoBaskets2TestsBase<T> where T : IFruitsIntoBaskets2, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 2, 5 }, new[] { 3, 5, 4 }, 1)]
    [DataRow(new[] { 3, 6, 1 }, new[] { 6, 4, 7 }, 0)]
    [DataRow(new[] { 1 }, new[] { 1 }, 0)]
    [DataRow(new[] { 2 }, new[] { 1 }, 1)]
    [DataRow(new[] { 1 }, new[] { 1000 }, 0)]
    [DataRow(new[] { 1000 }, new[] { 1000 }, 0)]
    [DataRow(new[] { 5, 5 }, new[] { 5 }, 1)]
    [DataRow(new[] { 5 }, new[] { 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 1)]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 4, 4, 4 }, new[] { 3, 3, 3 }, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 10, 20, 30 }, new[] { 30, 20, 10 }, 1)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6 }, 0)]
    [DataRow(new[] { 2, 2, 2 }, new[] { 1, 2, 3 }, 1)]
    [DataRow(new[] { 7, 8, 9 }, new[] { 10, 7, 8 }, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, new[] { 250, 150, 450, 50 }, 2)]
    [DataRow(new[] { 1000, 999, 998 }, new[] { 998, 999, 1000 }, 0)]
    [DataRow(new[] { 3, 6, 1, 8, 2 }, new[] { 5, 2, 7, 1, 9 }, 1)]
    [DataRow(new[] { 9, 9, 9, 9 }, new[] { 9, 8, 9, 10 }, 1)]
    public void NumOfUnplacedFruits_WithFruitsAndBaskets_ReturnsCountOfUnplacedFruitTypes(int[] fruits, int[] baskets, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumOfUnplacedFruits(fruits, baskets);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}