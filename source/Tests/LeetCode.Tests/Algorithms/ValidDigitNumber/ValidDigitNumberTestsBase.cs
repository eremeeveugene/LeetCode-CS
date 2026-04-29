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

using LeetCode.Algorithms.ValidDigitNumber;

namespace LeetCode.Tests.Algorithms.ValidDigitNumber;

public abstract class ValidDigitNumberTestsBase<T> where T : IValidDigitNumber, new()
{
    [TestMethod]
    [DataRow(101, 0, true)]
    [DataRow(232, 2, false)]
    [DataRow(5, 1, false)]
    [DataRow(12, 2, true)]
    [DataRow(21, 2, false)]
    [DataRow(122, 2, true)]
    [DataRow(222, 2, false)]
    [DataRow(202, 2, false)]
    [DataRow(200, 0, true)]
    [DataRow(100, 1, false)]
    [DataRow(9, 9, false)]
    [DataRow(9, 1, false)]
    [DataRow(90909, 0, true)]
    [DataRow(12345, 3, true)]
    [DataRow(12345, 6, false)]
    public void ValidDigit_WithGivenNumber_ReturnsTrueWhenContainsDigitAndDoesNotStartWithDigit(int n, int x, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidDigit(n, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}