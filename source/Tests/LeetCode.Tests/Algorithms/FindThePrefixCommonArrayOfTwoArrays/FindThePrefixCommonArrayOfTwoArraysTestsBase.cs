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

using LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

namespace LeetCode.Tests.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

public abstract class FindThePrefixCommonArrayOfTwoArraysTestsBase<T> where T : IFindThePrefixCommonArrayOfTwoArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 }, new[] { 0, 2 })]
    [DataRow(new[] { 1, 3, 2, 4 }, new[] { 3, 1, 2, 4 }, new[] { 0, 2, 3, 4 })]
    [DataRow(new[] { 2, 3, 1 }, new[] { 3, 1, 2 }, new[] { 0, 1, 3 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 0, 1, 3 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 }, new[] { 0, 1, 3 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 }, new[] { 0, 0, 2, 4 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 }, new[] { 0, 0, 2, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, new[] { 0, 0, 1, 3, 5 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 }, new[] { 0, 0, 1, 3, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 2, 3, 4, 5, 1 }, new[] { 0, 1, 2, 3, 5 })]
    [DataRow(new[] { 2, 3, 4, 5, 1 }, new[] { 1, 2, 3, 4, 5 }, new[] { 0, 1, 2, 3, 5 })]
    [DataRow(new[] { 1, 3, 5, 2, 4 }, new[] { 5, 1, 4, 3, 2 }, new[] { 0, 2, 3, 4, 5 })]
    [DataRow(new[] { 2, 5, 1, 4, 3 }, new[] { 4, 1, 5, 3, 2 }, new[] { 0, 1, 3, 4, 5 })]
    [DataRow(new[] { 6, 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6 }, new[] { 0, 1, 2, 3, 4, 6 })]
    [DataRow(new[] { 1, 6, 2, 5, 3, 4 }, new[] { 6, 1, 5, 2, 4, 3 }, new[] { 0, 2, 2, 4, 4, 6 })]
    [DataRow(new[] { 4, 1, 6, 2, 5, 3 }, new[] { 1, 2, 3, 4, 5, 6 }, new[] { 0, 1, 1, 4, 5, 6 })]
    public void FindThePrefixCommonArray_WithTwoIntegerArrays_ReturnsPrefixCommonCounts(int[] a, int[] b, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindThePrefixCommonArray(a, b);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}