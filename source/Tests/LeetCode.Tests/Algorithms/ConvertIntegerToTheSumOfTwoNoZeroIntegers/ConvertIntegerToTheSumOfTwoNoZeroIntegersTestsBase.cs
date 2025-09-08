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

using LeetCode.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

public abstract class ConvertIntegerToTheSumOfTwoNoZeroIntegersTestsBase<T>
    where T : IConvertIntegerToTheSumOfTwoNoZeroIntegers, new()
{
    [TestMethod]
    [DataRow(2, "[1,1]")]
    [DataRow(11, "[2,9]")]
    [DataRow(69, "[1,68]")]
    [DataRow(699, "[1,698]")]
    [DataRow(700, "[1,699]")]
    [DataRow(701, "[2,699]")]
    [DataRow(1010, "[11,999]")]
    public void GetNoZeroIntegers_WithPositiveIntegerN_ReturnsTwoNoZeroIntegersThatSumToN(int n,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.GetNoZeroIntegers(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}