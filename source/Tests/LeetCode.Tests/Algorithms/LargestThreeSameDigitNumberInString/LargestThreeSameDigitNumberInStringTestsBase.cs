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

using LeetCode.Algorithms.LargestThreeSameDigitNumberInString;

namespace LeetCode.Tests.Algorithms.LargestThreeSameDigitNumberInString;

public abstract class LargestThreeSameDigitNumberInStringTestsBase<T>
    where T : ILargestThreeSameDigitNumberInString, new()
{
    [TestMethod]
    [DataRow("222", "222")]
    [DataRow("74444", "444")]
    [DataRow("6777133339", "777")]
    [DataRow("2300019", "000")]
    [DataRow("42352338", "")]
    public void LargestGoodInteger_WithTripleRepeatingDigitSubstring_ReturnsMaximumGoodIntegerOrEmptyString(string num,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestGoodInteger(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}