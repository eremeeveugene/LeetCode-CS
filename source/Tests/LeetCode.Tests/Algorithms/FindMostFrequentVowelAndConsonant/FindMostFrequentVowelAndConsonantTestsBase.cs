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

using LeetCode.Algorithms.FindMostFrequentVowelAndConsonant;

namespace LeetCode.Tests.Algorithms.FindMostFrequentVowelAndConsonant;

public abstract class FindMostFrequentVowelAndConsonantTestsBase<T> where T : IFindMostFrequentVowelAndConsonant, new()
{
    [TestMethod]
    [DataRow("successes", 6)]
    [DataRow("aeiaeia", 3)]
    [DataRow("a", 1)]
    [DataRow("z", 1)]
    [DataRow("bcdf", 1)]
    [DataRow("aaaa", 4)]
    [DataRow("ab", 2)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 2)]
    [DataRow("aeiou", 1)]
    [DataRow("bbbbaaaa", 8)]
    [DataRow("hello", 3)]
    [DataRow("mississippi", 8)]
    [DataRow("programming", 3)]
    [DataRow("eeeeddddcccc", 8)]
    [DataRow("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu", 100)]
    [DataRow("xyzxyzxyzaei", 4)]
    [DataRow("zjtatugibmmuecoaqhacftqmulrcmahzsviynsd", 8)]
    [DataRow("urdtpjejjiqcehwkdyanxq", 5)]
    [DataRow("fqufpukqovkqkcaudppipisi", 7)]
    [DataRow("vffqjnvhgplnxtj", 2)]
    [DataRow("mvumjzzuwpljqexfjqkawgdykrbsrimxzurbw", 6)]
    [DataRow("vaetptlioqeemqcxkagnspaencmhyjyjy", 7)]
    public void MaxFreqSum_WithMixedVowelsAndConsonants_ReturnsSumOfMostFrequentCounts(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFreqSum(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}