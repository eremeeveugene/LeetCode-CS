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

using LeetCode.Algorithms.CheckIfTheSentenceIsPangram;

namespace LeetCode.Tests.Algorithms.CheckIfTheSentenceIsPangram;

public abstract class CheckIfTheSentenceIsPangramTestsBase<T> where T : ICheckIfTheSentenceIsPangram, new()
{
    [TestMethod]
    [DataRow("abcdefghijklmnopqrstuvxwyz", true)]
    [DataRow("thequickbrownfoxjumpsoverthelazydog", true)]
    [DataRow("leetcode", false)]
    [DataRow(
        "jwtucoucmdfwxxqnxzkaxoglszmfrcvjoiunqqausaxxaaijyqdqgvdnqcaihwilqkpivenpnekioyqujrdrovqrlxovcucjqzjsxmllfgndfprctxvxwlzjtciqxgsxfwhmuzqvlksyuztoetyjugmswfjtawwaqmwyxmvo",
        false)]
    public void CheckIfPangram_WithGivenSentence_ReturnsTrueIfPangramFalseOtherwise(string sentence,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckIfPangram(sentence);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}