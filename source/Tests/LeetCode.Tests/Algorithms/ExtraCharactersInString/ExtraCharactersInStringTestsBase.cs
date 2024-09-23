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

using LeetCode.Algorithms.ExtraCharactersInString;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ExtraCharactersInString;

public abstract class ExtraCharactersInStringTestsBase<T> where T : IExtraCharactersInString, new()
{
    [TestMethod]
    [DataRow("leetsleetscode", "[\"leets\", \"code\"]", 0)]
    [DataRow("leetscode", "[\"leet\",\"code\",\"leetcode\"]", 1)]
    [DataRow("leecodet", "[\"leet\",\"code\"]", 4)]
    [DataRow("sayhelloworld", "[\"hello\",\"world\"]", 3)]
    [DataRow("dwmodizxvvbosxxw",
        "[\"ox\",\"lb\",\"diz\",\"gu\",\"v\",\"ksv\",\"o\",\"nuq\",\"r\",\"txhe\",\"e\",\"wmo\",\"cehy\",\"tskz\",\"ds\",\"kzbu\"]",
        7)]
    [DataRow("azvzulhlwxwobowijiyebeaskecvtjqwkmaqnvnaomaqnvf",
        "[\"na\",\"i\",\"edd\",\"wobow\",\"kecv\",\"b\",\"n\",\"or\",\"jj\",\"zul\",\"vk\",\"yeb\",\"qnfac\",\"azv\",\"grtjba\",\"yswmjn\",\"xowio\",\"u\",\"xi\",\"pcmatm\",\"maqnv\"]",
        15)]
    public void MinExtraChar_WithStringAndDictionary_ReturnsMinExtraChars(string s, string dictionaryJsonArray,
        int expectedResult)
    {
        // Arrange
        var dictionary = JsonHelper<string>.DeserializeToArray(dictionaryJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinExtraChar(s, dictionary);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}