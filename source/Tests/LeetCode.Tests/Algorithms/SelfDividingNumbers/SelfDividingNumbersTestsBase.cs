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

using LeetCode.Algorithms.SelfDividingNumbers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SelfDividingNumbers;

public abstract class SelfDividingNumbersTestsBase<T> where T : ISelfDividingNumbers, new()
{
    [TestMethod]
    [DataRow(1, 22, "[1,2,3,4,5,6,7,8,9,11,12,15,22]")]
    [DataRow(47, 85, "[48,55,66,77]")]
    public void SelfDividingNumbers_WithRangeBounds_ReturnsListOfSelfDividingNumbersWithinRange(int left, int right,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SelfDividingNumbers(left, right).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}