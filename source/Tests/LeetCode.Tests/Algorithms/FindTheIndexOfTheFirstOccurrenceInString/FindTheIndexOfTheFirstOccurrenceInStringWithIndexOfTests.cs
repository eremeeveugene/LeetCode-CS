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

using LeetCode.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

namespace LeetCode.Tests.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

[TestClass]
public class FindTheIndexOfTheFirstOccurrenceInStringWithIndexOfTests
{
    [TestMethod]
    [DataRow("sadbutsad", "sad", 0)]
    [DataRow("leetcode", "leeto", -1)]
    public void StrStr_WithHaystackAndNeedle_ReturnsCorrectIndexOrMinusOne(string haystack, string needle,
        int expectedResult)
    {
        // Act
        var actualResult = FindTheIndexOfTheFirstOccurrenceInStringWithIndexOf.StrStr(haystack, needle);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}