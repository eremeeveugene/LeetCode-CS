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

using LeetCode.Algorithms.RankTransformOfAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RankTransformOfAnArray;

public abstract class RankTransformOfAnArrayTestsBase<T> where T : IRankTransformOfAnArray, new()
{
    [TestMethod]
    [DataRow("[40,10,20,30]", "[4,1,2,3]")]
    [DataRow("[100,100,100]", "[1,1,1]")]
    [DataRow("[37,12,28,9,100,56,80,5,12]", "[5,3,4,2,8,6,7,1,3]")]
    public void ArrayRankTransform_WithUnsortedArray_ReturnsRankedArray(string arrJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ArrayRankTransform(arr);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}