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

using LeetCode.Algorithms.KeyboardRow;

namespace LeetCode.Tests.Algorithms.KeyboardRow;

public abstract class KeyboardRowTestsBase<T> where T : IKeyboardRow, new()
{
    [TestMethod]
    [DataRow(new[] { "Hello", "Alaska", "Dad", "Peace" }, new[] { "Alaska", "Dad" })]
    [DataRow(new[] { "omk" }, new string[0])]
    [DataRow(new[] { "adsdf", "sfd" }, new[] { "adsdf", "sfd" })]
    [DataRow(new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "qwerty" }, new[] { "qwerty" })]
    [DataRow(new[] { "Qwerty", "QWERTY", "qwErTy" }, new[] { "Qwerty", "QWERTY", "qwErTy" })]
    [DataRow(new[] { "zxcv", "zxcvbnm", "zxcvbnmq" }, new[] { "zxcv", "zxcvbnm" })]
    [DataRow(new[] { "ASDFGHJKL", "asdfghjkl", "asdfghjklz" }, new[] { "ASDFGHJKL", "asdfghjkl" })]
    [DataRow(new[] { "abc", "def" }, new string[0])]
    [DataRow(new[] { "type", "row", "pot", "quiz" }, new[] { "type", "row", "pot" })]
    [DataRow(new[] { "a", "B", "c", "D" }, new[] { "a", "B", "c", "D" })]
    [DataRow(new[] { "Mom", "Dad", "Sis" }, new[] { "Dad" })]
    [DataRow(new[] { "Typewriter", "Qwertyuiop", "Flask" }, new[] { "Typewriter", "Qwertyuiop", "Flask" })]
    [DataRow(
        new[]
        {
            "QWERTYUIOPQWERTYUIOPQWERTYUIOP",
            "asdfghjklasdfghjklasdfghjklasdfghjklasdfghjkl",
            "zxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnm",
            "Qa"
        },
        new[]
        {
            "QWERTYUIOPQWERTYUIOPQWERTYUIOP",
            "asdfghjklasdfghjklasdfghjklasdfghjklasdfghjkl",
            "zxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnmzxcvbnm"
        })]
    [DataRow(new[] { "Z", "X", "C", "V", "B", "N", "M" }, new[] { "Z", "X", "C", "V", "B", "N", "M" })]
    [DataRow(new[] { "aSDfgHJkl", "ZXCvBNm", "qwEruTYIOp", "qa", "az", "sx" }, new[] { "aSDfgHJkl", "ZXCvBNm", "qwEruTYIOp" })]
    [DataRow(new[] { "ab", "cd", "ef", "gh", "ij" }, new[] { "gh" })]
    [DataRow(new[] { "pop", "lol", "mnb", "poi", "lkj" }, new[] { "pop", "mnb", "poi", "lkj" })]
    [DataRow(new[] { "j", "Yuy", "ZvcX", "yItEiiEW" }, new[] { "j", "Yuy", "ZvcX", "yItEiiEW" })]
    [DataRow(new[] { "LsdH", "PCcnruzm", "rqeEyiui" }, new[] { "LsdH", "rqeEyiui" })]
    public void FilterWordsByKeyboardRow_WithInputWordsArray_ReturnsMatchingWords(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindWords(words);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}