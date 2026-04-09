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

using LeetCode.Algorithms.TheTwoSneakyNumbersOfDigitville;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TheTwoSneakyNumbersOfDigitville;

public abstract class TheTwoSneakyNumbersOfDigitvilleTestsBase<T> where T : ITheTwoSneakyNumbersOfDigitville, new()
{
    [TestMethod]
    [DataRow("[0,1,1,0]", "[0,1]")]
    [DataRow("[0,3,2,1,3,2]", "[2,3]")]
    [DataRow("[7,1,5,4,3,4,6,0,9,5,8,2]", "[4,5]")]
    public void GetSneakyNumbers_GivenArrayOfNumbers_ReturnsSneakyNumbers(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.GetSneakyNumbers(nums);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}