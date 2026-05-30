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

using LeetCode.Algorithms.LargestEvenNumber;

namespace LeetCode.Tests.Algorithms.LargestEvenNumber;

public abstract class LargestEvenNumberTestsBase<T> where T : ILargestEvenNumber, new()
{
    [TestMethod]
    [DataRow("1", "")]
    [DataRow("221", "22")]
    [DataRow("1112", "1112")]
    public void LargestEven_WithOnlyOnesAndTwos_ReturnsLongestEvenIntegerStringByRemovingCharacters(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestEven(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}