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

using LeetCode.Algorithms.ReverseWordsInString3;

namespace LeetCode.Tests.Algorithms.ReverseWordsInString3;

public abstract class ReverseWordsInString3TestsBase<T> where T : IReverseWordsInString3, new()
{
    [TestMethod]
    [DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [DataRow("Mr Ding", "rM gniD")]
    public void ReverseWords_WithString_ReversesEachWord(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseWords(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}