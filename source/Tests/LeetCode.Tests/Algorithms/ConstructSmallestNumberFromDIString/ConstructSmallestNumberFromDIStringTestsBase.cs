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

using LeetCode.Algorithms.ConstructSmallestNumberFromDIString;

namespace LeetCode.Tests.Algorithms.ConstructSmallestNumberFromDIString;

public abstract class ConstructSmallestNumberFromDIStringTestsBase<T>
    where T : IConstructSmallestNumberFromDIString, new()
{
    [TestMethod]
    [DataRow("DDD", "4321")]
    [DataRow("IIIDIDDD", "123549876")]
    public void SmallestNumber_WithGivenPattern_ReturnsLexicographicallySmallestPermutation(string pattern,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestNumber(pattern);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}