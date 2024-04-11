// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RemoveKDigits;

namespace LeetCode.Tests.Algorithms.RemoveKDigits;

public abstract class RemoveKDigitsTestsBase<T> where T : IRemoveKDigits, new()
{
    [TestMethod]
    [DataRow("10", 2, "0")]
    [DataRow("500", 3, "0")]
    [DataRow("10200", 1, "200")]
    [DataRow("1432219", 3, "1219")]
    [DataRow("1234567", 1, "123456")]
    [DataRow("3238900989831", 5, "989831")]
    [DataRow("3238900989831", 6, "89831")]
    [DataRow("52374333400072837283091820", 6, "23300072837283091820")]
    public void RemoveKDigits_GivenNumberAndK_ReturnsExpectedSmallestNumber(string num, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveKdigits(num, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}