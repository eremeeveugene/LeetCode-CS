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
    public void NumOfUnplacedFruits_WithFruitsAndBaskets_ReturnsCountOfUnplacedFruitTypes(int[] fruits,
        int[] baskets, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumOfUnplacedFruits(fruits, baskets);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}