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

using LeetCode.Core.Helpers;

namespace LeetCode.Core.Tests.Helpers;

[TestClass]
public sealed class JsonHelperTests
{
    [TestMethod]
    [DataRow("\"hello\"", "hello")]
    [DataRow("\"\"", "")]
    public void Parse_WithJsonString_ReturnsParsedString(string stringJson, string expectedResult)
    {
        // Act
        var actualResult = JsonHelper<string>.Parse(stringJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("null", null)]
    [DataRow("\"hello\"", "hello")]
    [DataRow("\"\"", "")]
    public void Parse_WithNullableJsonString_ReturnsParsedNullableString(string nullableStringJson,
        string? expectedResult)
    {
        // Act
        var actualResult = JsonHelper<string?>.Parse(nullableStringJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("true", true)]
    [DataRow("false", false)]
    public void Parse_WithBoolJsonString_ReturnsParsedBool(string boolJson, bool expectedResult)
    {
        // Act
        var actualResult = JsonHelper<bool>.Parse(boolJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("123", 123)]
    [DataRow("-5", -5)]
    public void Parse_WithIntJsonString_ReturnsParsedInt(string intJson, int expectedResult)
    {
        // Act
        var actualResult = JsonHelper<int>.Parse(intJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("null", null)]
    [DataRow("42", 42)]
    public void Parse_WithNullableIntJsonString_ReturnsParsedNullableInt(string nullableIntJson, int? expectedResult)
    {
        // Act
        var actualResult = JsonHelper<int?>.Parse(nullableIntJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("3000000000", 3000000000L)]
    public void Parse_WithLongJsonString_ReturnsParsedLong(string longJson, long expectedResult)
    {
        // Act
        var actualResult = JsonHelper<long>.Parse(longJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("3.14", 3.14)]
    [DataRow("0.0", 0.0)]
    public void Parse_WithDoubleJsonString_ReturnsParsedDouble(string doubleJson, double expectedResult)
    {
        // Act
        var actualResult = JsonHelper<double>.Parse(doubleJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult, double.Epsilon);
    }
}