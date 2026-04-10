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
    [DataRow("\"world\"", "world")]
    [DataRow("\"hello world\"", "hello world")]
    [DataRow("\"123\"", "123")]
    [DataRow("\"special !@#$%\"", "special !@#$%")]
    [DataRow("\"unicode: \\u00e9\"", "unicode: é")]
    [DataRow("\"tab:\\there\"", "tab:\there")]
    [DataRow("\"newline:\\nhere\"", "newline:\nhere")]
    public void Parse_WithJsonString_ReturnsParsedString(string stringJson, string expectedResult)
    {
        // Act
        var actualResult = JsonHelper.Parse<string>(stringJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("true", true)]
    [DataRow("false", false)]
    public void Parse_WithBoolJsonString_ReturnsParsedBool(string boolJson, bool expectedResult)
    {
        // Act
        var actualResult = JsonHelper.Parse<bool>(boolJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("123", 123)]
    [DataRow("-5", -5)]
    [DataRow("0", 0)]
    [DataRow("1", 1)]
    [DataRow("-1", -1)]
    [DataRow("2147483647", int.MaxValue)]
    [DataRow("-2147483648", int.MinValue)]
    public void Parse_WithIntJsonString_ReturnsParsedInt(string intJson, int expectedResult)
    {
        // Act
        var actualResult = JsonHelper.Parse<int>(intJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("3000000000", 3000000000L)]
    [DataRow("0", 0L)]
    [DataRow("-1", -1L)]
    [DataRow("9223372036854775807", long.MaxValue)]
    [DataRow("-9223372036854775808", long.MinValue)]
    [DataRow("-3000000000", -3000000000L)]
    public void Parse_WithLongJsonString_ReturnsParsedLong(string longJson, long expectedResult)
    {
        // Act
        var actualResult = JsonHelper.Parse<long>(longJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("3.14", 3.14)]
    [DataRow("0.0", 0.0)]
    [DataRow("-3.14", -3.14)]
    [DataRow("1.0", 1.0)]
    [DataRow("-1.0", -1.0)]
    [DataRow("1.7976931348623157E+308", double.MaxValue)]
    [DataRow("-1.7976931348623157E+308", double.MinValue)]
    [DataRow("1E-10", 1e-10)]
    [DataRow("1.5E+10", 1.5e+10)]
    public void Parse_WithDoubleJsonString_ReturnsParsedDouble(string doubleJson, double expectedResult)
    {
        // Act
        var actualResult = JsonHelper.Parse<double>(doubleJson);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}