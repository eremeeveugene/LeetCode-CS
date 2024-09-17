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

using LeetCode.Algorithms.KthLargestElementInStream;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.KthLargestElementInStream;

public abstract class KthLargestElementInStreamTestsBase<T> where T : IKthLargestElementInStreamFactory, new()
{
    [TestMethod]
    [DataRow(1, "[]", "[1, 2, 3, 4, 5]", "[1, 2, 3, 4, 5]")]
    [DataRow(1, "[]", "[-3, -2, -4, 0, 4]", "[-3, -2, -2, 0, 4]")]
    [DataRow(5, "[1, 2, 3, 4, 5]", "[6, 7, 8, 9]", "[2, 3, 4, 5]")]
    [DataRow(1, "[2, 3, 5]", "[4, 6, 1]", "[5, 6, 6]")]
    [DataRow(2, "[0]", "[-1, 1, -2, -4, 3]", "[-1, 0, 0, 0, 1]")]
    [DataRow(2, "[1, 2, 3, 4]", "[5, 6, 7, 8]", "[4, 5, 6, 7]")]
    [DataRow(4, "[10, 9, 8, 7]", "[6, 5, 4]", "[7, 7, 7]")]
    [DataRow(2, "[100, 99, 98]", "[101, 102, 97]", "[100, 101, 101]")]
    [DataRow(5, "[1, 2, 3, 4, 5]", "[6, 7, 8, 9, 10]", "[2, 3, 4, 5, 6]")]
    [DataRow(3, "[-1, -2, -3, -4, -5]", "[-6, -7, -8, -9]", "[-3, -3, -3, -3]")]
    public void Add_WhenCalledWithValues_ReturnsKthLargestElements(int k, string numsJsonArray, string valuesJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var values = JsonHelper<int>.DeserializeToArray(valuesJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var kthLargestElementInStreamFactory = new T();
        var kthLargestElementInStream = kthLargestElementInStreamFactory.Create(k, nums);

        // Act
        var actualResult = new int[values.Length];

        for (var i = 0; i < values.Length; i++)
        {
            actualResult[i] = kthLargestElementInStream.Add(values[i]);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}