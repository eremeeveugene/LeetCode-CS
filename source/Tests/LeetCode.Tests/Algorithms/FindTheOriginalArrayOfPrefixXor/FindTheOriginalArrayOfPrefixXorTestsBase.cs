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

using LeetCode.Algorithms.FindTheOriginalArrayOfPrefixXor;

namespace LeetCode.Tests.Algorithms.FindTheOriginalArrayOfPrefixXor;

public abstract class FindTheOriginalArrayOfPrefixXorTestsBase<T> where T : IFindTheOriginalArrayOfPrefixXor, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 0, 3, 1 }, new[] { 5, 7, 2, 3, 2 })]
    [DataRow(new[] { 13 }, new[] { 13 })]
    [DataRow(new[] { 13 }, new[] { 13 })]
    public void FindArray_WithPrefixArray_ReturnsOriginalArray(int[] pref, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindArray(pref);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}