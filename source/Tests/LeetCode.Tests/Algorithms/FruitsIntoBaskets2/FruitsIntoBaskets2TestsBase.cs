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

using LeetCode.Algorithms.FruitsIntoBaskets2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FruitsIntoBaskets2;

public abstract class FruitsIntoBaskets2TestsBase<T> where T : IFruitsIntoBaskets2, new()
{
    [TestMethod]
    [DataRow("[4,2,5]", "[3,5,4]", 1)]
    [DataRow("[3,6,1]", "[6,4,7]", 0)]
    public void NumOfUnplacedFruits_WithFruitsAndBaskets_ReturnsCountOfUnplacedFruitTypes(string fruitsJson,
        string basketsJson, int expectedResult)
    {
        // Arrange
        var fruits = JsonHelper<int[]>.Parse(fruitsJson);
        var baskets = JsonHelper<int[]>.Parse(basketsJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumOfUnplacedFruits(fruits, baskets);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}