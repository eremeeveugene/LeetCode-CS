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

using LeetCode.Algorithms.LexicographicalNumbers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LexicographicalNumbers;

public abstract class LexicographicalNumbersTestsBase<T> where T : ILexicographicalNumbers, new()
{
    [TestMethod]
    [DataRow(1, "[1]")]
    [DataRow(2, "[1,2]")]
    [DataRow(9, "[1,2,3,4,5,6,7,8,9]")]
    [DataRow(10, "[1,10,2,3,4,5,6,7,8,9]")]
    [DataRow(13, "[1,10,11,12,13,2,3,4,5,6,7,8,9]")]
    [DataRow(50,
        "[1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,6,7,8,9]")]
    public void LexicalOrder_WithGivenN_ReturnsLexicographicallySortedArray(int n, string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LexicalOrder(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}