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

using LeetCode.Algorithms.PermutationInString;

namespace LeetCode.Tests.Algorithms.PermutationInString;

public abstract class PermutationInStringTestsBase<T> where T : IPermutationInString, new()
{
    [TestMethod]
    [DataRow("ab", "eidbaooo", true)]
    [DataRow("ab", "eidboaoo", false)]
    [DataRow("bc", "ad", false)]
    [DataRow("adc", "dcda", true)]
    [DataRow("abc", "defabc", true)]
    [DataRow("hello", "ooolleoooleh", false)]
    public void CheckInclusion_WithTwoStrings_ReturnsTrueIfFirstIsPermutationOfSecond(string s1, string s2,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckInclusion(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}