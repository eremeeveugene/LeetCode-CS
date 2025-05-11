// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;
using System.Text.Json;

namespace LeetCode.Core.Tests.Helpers;

[TestClass]
public class JsonHelperTests
{
    [TestMethod]
    public void DeserializeToArray_WithValidJson_ReturnsDeserializedArray()
    {
        // Arrange
        var expectedResult = new[] { 1, 2, 3 };

        // Act
        var actualResult = JsonHelper<int>.DeserializeToArray("[1,2,3]");

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void DeserializeToJaggedArray_WithValidJson_ReturnsDeserializedJaggedArray()
    {
        // Arrange
        var expectedResult = new[] { new[] { 1, 2 }, [3, 4] };

        // Act
        var actualResult = JsonHelper<int>.DeserializeToJaggedArray("[[1,2],[3,4]]");

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void DeserializeToJaggedList_WithValidJson_ReturnsDeserializedJaggedList()
    {
        // Arrange
        var expectedResult = new[] { new[] { 1, 2 }, [3, 4] };

        // Act
        var actualResult = JsonHelper<int>.DeserializeToJaggedList("[[1,2],[3,4]]");

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void DeserializeToArray_InvalidJson_ThrowsJsonException()
    {
        Assert.ThrowsExactly<JsonException>(() => JsonHelper<int>.DeserializeToArray("invalid"));
    }

    [TestMethod]
    public void DeserializeToJaggedArray_InvalidJson_ThrowsJsonException()
    {
        Assert.ThrowsExactly<JsonException>(() => JsonHelper<int>.DeserializeToJaggedArray("invalid"));
    }

    [TestMethod]
    public void DeserializeToJaggedList_InvalidJson_ThrowsJsonException()
    {
        Assert.ThrowsExactly<JsonException>(() => JsonHelper<int>.DeserializeToJaggedList("invalid"));
    }
}