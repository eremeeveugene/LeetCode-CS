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

using LeetCode.Algorithms.ClearDigits;

namespace LeetCode.Tests.Algorithms.ClearDigits;

public abstract class ClearDigitsTestsBase<T> where T : IClearDigits, new()
{
    [TestMethod]
    [DataRow("abc", "abc")]
    [DataRow("cb34", "")]
    public void ClearDigits_GivenStringWithLettersAndDigits_ReturnsStringWithoutDigits(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClearDigits(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}