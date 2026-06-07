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

using LeetCode.Algorithms.SortVowelsInString;

namespace LeetCode.Tests.Algorithms.SortVowelsInString;

public abstract class SortVowelsInStringTestsBase<T> where T : ISortVowelsInString, new()
{
    [TestMethod]
    [DataRow("lEetcOde", "lEOtcede")]
    [DataRow("lYmpH", "lYmpH")]
    [DataRow("a", "a")]
    [DataRow("z", "z")]
    [DataRow("aeiou", "aeiou")]
    [DataRow("AEIOU", "AEIOU")]
    [DataRow("uoiea", "aeiou")]
    [DataRow("UOIEA", "AEIOU")]
    [DataRow("bcdfg", "bcdfg")]
    [DataRow("aAbBcC", "AabBcC")]
    [DataRow("eAiOu", "AOeiu")]
    [DataRow("hello", "hello")]
    [DataRow("Aeio", "Aeio")]
    [DataRow("oiea", "aeio")]
    [DataRow("bUaRd", "bUaRd")]
    [DataRow("AbCdEfGh", "AbCdEfGh")]
    [DataRow("uuuu", "uuuu")]
    [DataRow("AaEeIiOoUu", "AEIOUaeiou")]
    [DataRow("bcdfghjklm", "bcdfghjklm")]
    [DataRow("aeiouAEIOU", "AEIOUaeiou")]
    public void SortVowels_WithString_SortsVowelsByAsciiOrder(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortVowels(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}