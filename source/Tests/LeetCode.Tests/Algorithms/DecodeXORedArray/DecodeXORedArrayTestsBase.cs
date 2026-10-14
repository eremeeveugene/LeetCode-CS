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

using LeetCode.Algorithms.DecodeXORedArray;

namespace LeetCode.Tests.Algorithms.DecodeXORedArray;

public abstract class DecodeXORedArrayTestsBase<T> where T : IDecodeXORedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 1, new[] { 1, 0, 2, 1 })]
    [DataRow(new[] { 6, 2, 7, 3 }, 4, new[] { 4, 2, 0, 7, 4 })]
    [DataRow(new[] { 0 }, 0, new[] { 0, 0 })]
    [DataRow(new[] { 0 }, 5, new[] { 5, 5 })]
    [DataRow(new[] { 1 }, 0, new[] { 0, 1 })]
    [DataRow(new[] { 1 }, 1, new[] { 1, 0 })]
    [DataRow(new[] { 5, 5 }, 3, new[] { 3, 6, 3 })]
    [DataRow(new[] { 100000 }, 100000, new[] { 100000, 0 })]
    [DataRow(new[] { 0, 0, 0 }, 7, new[] { 7, 7, 7, 7 })]
    [DataRow(new[] { 1, 2, 4, 8 }, 0, new[] { 0, 1, 3, 7, 15 })]
    [DataRow(new[] { 1, 2, 4, 8 }, 15, new[] { 15, 14, 12, 8, 0 })]
    [DataRow(new[] { 3, 3, 3, 3 }, 3, new[] { 3, 0, 3, 0, 3 })]
    [DataRow(new[] { 100000, 100000 }, 100000, new[] { 100000, 0, 100000 })]
    [DataRow(new[] { 7, 7, 7 }, 0, new[] { 0, 7, 0, 7 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 1, new[] { 1, 11, 31, 1, 41, 27 })]
    [DataRow(new[] { 65535, 1 }, 2, new[] { 2, 65533, 65532 })]
    [DataRow(new[] { 2, 4, 6 }, 8, new[] { 8, 10, 14, 8 })]
    [DataRow(new[] { 99999, 12345, 54321 }, 77777, new[] { 77777, 43342, 39287, 19782 })]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 1, new[] { 1, 0, 1, 0, 1, 0, 1 })]
    [DataRow(new[] { 9, 0, 9, 0 }, 4, new[] { 4, 13, 13, 4, 4 })]
    public void Decode_WithEncodedArrayAndFirstElement_ReturnsOriginalXorDecodedArray(int[] encoded, int first, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Decode(encoded, first);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}