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

using LeetCode.Algorithms.DecodeXORedArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DecodeXORedArray;

public abstract class DecodeXORedArrayTestsBase<T> where T : IDecodeXORedArray, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3]", 1, "[1, 0, 2, 1]")]
    [DataRow("[6, 2, 7, 3]", 4, "[4, 2, 0, 7, 4]")]
    public void Decode_GivenEncodedArrayAndFirstElement_ReturnsExpectedDecodedArray(
        string encodedJsonArray, int first, string expectedResultJsonArray)
    {
        // Arrange
        var encoded = JsonHelper<int>.DeserializeToArray(encodedJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Decode(encoded, first);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}