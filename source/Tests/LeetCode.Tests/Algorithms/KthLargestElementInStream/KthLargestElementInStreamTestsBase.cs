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

namespace LeetCode.Tests.Algorithms.KthLargestElementInStream;

public abstract class KthLargestElementInStreamTestsBase<T> where T : IKthLargestElementInStreamFactory, new()
{
    [TestMethod]
    [DataRow(1, new int[0], new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(1, new int[0], new[] { -3, -2, -4, 0, 4 }, new[] { -3, -2, -2, 0, 4 })]
    [DataRow(5, new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9 }, new[] { 2, 3, 4, 5 })]
    [DataRow(1, new[] { 2, 3, 5 }, new[] { 4, 6, 1 }, new[] { 5, 6, 6 })]
    [DataRow(2, new[] { 0 }, new[] { -1, 1, -2, -4, 3 }, new[] { -1, 0, 0, 0, 1 })]
    [DataRow(2, new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 4, 5, 6, 7 })]
    [DataRow(4, new[] { 10, 9, 8, 7 }, new[] { 6, 5, 4 }, new[] { 7, 7, 7 })]
    [DataRow(2, new[] { 100, 99, 98 }, new[] { 101, 102, 97 }, new[] { 100, 101, 101 })]
    [DataRow(5, new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, new[] { 2, 3, 4, 5, 6 })]
    [DataRow(3, new[] { -1, -2, -3, -4, -5 }, new[] { -6, -7, -8, -9 }, new[] { -3, -3, -3, -3 })]
    public void Add_WhenCalledWithValues_ReturnsKthLargestElements(int k, int[] nums, int[] values,
        int[] expectedResult)
    {
        // Arrange
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