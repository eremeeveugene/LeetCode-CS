// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RomanToInteger.Iterative;

namespace LeetCode.Tests.Algorithms.RomanToInteger;

[TestClass]
public class RomanToIntegerIterativeTests
{
    [TestMethod]
    [DataRow("III",     3)]
    [DataRow("LVIII",   58)]
    [DataRow("MCMXCIV", 1994)]
    public void RomanToIntegerIterative_GetResult_ShouldConvertToCorrectIntegerValue(string romanString,
        int                                                                                 expectedResult)
    {
        // Act
        var actualResult = RomanToIntegerIterative.GetResult(romanString);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}