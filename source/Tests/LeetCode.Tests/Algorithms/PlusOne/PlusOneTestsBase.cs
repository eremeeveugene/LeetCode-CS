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

using LeetCode.Algorithms.PlusOne;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PlusOne;

public abstract class PlusOneTestsBase<T> where T : IPlusOne, new()
{
    [TestMethod]
    [DataRow("[1,2,3]", "[1,2,4]")]
    [DataRow("[4,3,2,1]", "[4,3,2,2]")]
    [DataRow("[9]", "[1,0]")]
    [DataRow("[9,9]", "[1,0,0]")]
    [DataRow("[8,9,9,9]", "[9,0,0,0]")]
    [DataRow("[9,8,7,6,5,4,3,2,1,0]", "[9,8,7,6,5,4,3,2,1,1]")]
    [DataRow("[7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6]",
        "[7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,7]")]
    public void PlusOne_WithDigitArray_ReturnsIncrementedNumberArray(string digitsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var digits = JsonHelper<int>.DeserializeToArray(digitsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.PlusOne(digits);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}