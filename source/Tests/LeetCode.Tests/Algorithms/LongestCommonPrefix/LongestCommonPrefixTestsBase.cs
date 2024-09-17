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

using LeetCode.Algorithms.LongestCommonPrefix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LongestCommonPrefix;

public abstract class LongestCommonPrefixTestsBase<T> where T : ILongestCommonPrefix, new()
{
    [TestMethod]
    [DataRow("[\"\"]", "")]
    [DataRow("[\"dog\",\"racecar\",\"car\"]", "")]
    [DataRow("[\"flower\",\"flow\",\"flight\"]", "fl")]
    [DataRow("[\"flower\",\"flower\",\"flower\",\"flower\"]", "flower")]
    [DataRow("[\"interview\",\"interrupt\",\"integrate\",\"integral\"]", "inte")]
    [DataRow("[\"interspecies\",\"interstellar\",\"interstate\"]", "inters")]
    [DataRow("[\"throne\",\"throne\"]", "throne")]
    [DataRow("[\"throne\",\"throne\",\"thro\"]", "thro")]
    [DataRow("[\"a\",\"b\"]", "")]
    [DataRow("[\"a\"]", "a")]
    [DataRow("[\"abcd\"]", "abcd")]
    [DataRow("[\"prefix\",\"pretext\",\"preference\",\"pre\"]", "pre")]
    [DataRow("[\"ab\",\"ab\",\"abc\"]", "ab")]
    [DataRow("[\"longest\",\"longer\",\"long\",\"longing\"]", "long")]
    public void LongestCommonPrefix_GivenStringsArray_ReturnsCorrectCommonPrefix(string strsJsonArray,
        string expectedResult)
    {
        // Arrange
        var strs = JsonHelper<string>.DeserializeToArray(strsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LongestCommonPrefix(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}