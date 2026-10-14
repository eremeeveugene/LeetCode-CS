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
    [DataRow("2", "2")]
    [DataRow("11", "")]
    [DataRow("12", "12")]
    [DataRow("21", "2")]
    [DataRow("22", "22")]
    [DataRow("111", "")]
    [DataRow("112", "112")]
    [DataRow("121", "12")]
    [DataRow("211", "2")]
    [DataRow("2111", "2")]
    [DataRow("1211", "12")]
    [DataRow("2121", "212")]
    [DataRow("1212", "1212")]
    [DataRow("12121", "1212")]
    [DataRow("22222", "22222")]
    [DataRow("11111", "")]
    [DataRow("21212", "21212")]
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