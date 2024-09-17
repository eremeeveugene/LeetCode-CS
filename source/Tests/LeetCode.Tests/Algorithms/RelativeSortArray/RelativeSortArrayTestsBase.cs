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

using LeetCode.Algorithms.RelativeSortArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RelativeSortArray;

public abstract class RelativeSortArrayTestsBase<T> where T : IRelativeSortArray, new()
{
    [TestMethod]
    [DataRow("[2,3,1,3,2,4,6,7,9,2,19]", "[2,1,4,3,9,6]", "[2,2,2,1,4,3,3,9,6,7,19]")]
    [DataRow("[28,6,22,8,44,17]", "[22,28,8,6]", "[22,28,8,6,17,44]")]
    public void RelativeSortArray_WithGivenArrays_ReturnsCorrectlySortedArray(string arr1JsonArray,
        string arr2JsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var arr1 = JsonHelper<int>.DeserializeToArray(arr1JsonArray);
        var arr2 = JsonHelper<int>.DeserializeToArray(arr2JsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RelativeSortArray(arr1, arr2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}