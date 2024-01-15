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

[TestClass]
public class ReverseWordsInString3WithCharArrayTests
{
    [TestMethod]
    [DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [DataRow("Mr Ding", "rM gniD")]
    public void ReverseWordsInString3WithCharArray_ReverseWords_WithStringInput_ReturnsReversedWords(string s,
        string expectedResult)
    {
        // Act
        var actualResult = ReverseWordsInString3WithCharArray.ReverseWords(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}