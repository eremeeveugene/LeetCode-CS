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

using LeetCode.Algorithms.FindNumbersWithEvenNumberOfDigits;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindNumbersWithEvenNumberOfDigits;

public abstract class FindNumbersWithEvenNumberOfDigitsTestsBase<T> where T : IFindNumbersWithEvenNumberOfDigits, new()
{
    [TestMethod]
    [DataRow("[555,901,482,1771]", 1)]
    [DataRow("[12,345,2,6,7896]", 2)]
    public void FindNumbers_WithArrayOfIntegers_ReturnsCountOfNumbersWithEvenNumberOfDigits(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindNumbers(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}