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

using LeetCode.Algorithms.ReversePrefixOfWord;

namespace LeetCode.Tests.Algorithms.ReversePrefixOfWord;

public abstract class ReverseStringTestsBase<T> where T : IReversePrefixOfWord, new()
{
    [TestMethod]
    [DataRow("abcdefd", 'd', "dcbaefd")]
    [DataRow("xyxzxe", 'z', "zxyxxe")]
    [DataRow("abcd", 'z', "abcd")]
    [DataRow("a", 'a', "a")]
    [DataRow("a", 'b', "a")]
    [DataRow("ab", 'a', "ab")]
    [DataRow("ab", 'b', "ba")]
    [DataRow("abab", 'b', "baab")]
    [DataRow("aaaa", 'a', "aaaa")]
    [DataRow("abcdef", 'f', "fedcba")]
    [DataRow("abcdef", 'a', "abcdef")]
    [DataRow("abcdef", 'c', "cbadef")]
    [DataRow("zyxwv", 'x', "xyzwv")]
    [DataRow("hello", 'l', "lehlo")]
    [DataRow("hello", 'o', "olleh")]
    [DataRow("hello", 'z', "hello")]
    [DataRow("racecar", 'e', "ecarcar")]
    [DataRow("mississippi", 's', "simsissippi")]
    [DataRow("abcabcabc", 'c', "cbaabcabc")]
    [DataRow("pqhxmckayglwqzadveinetromvtixnqpyacmpcmyofikvpogplcufhcfqsgzewqwlnscbzfryquplieorfuzfzekicwpkktnzsgxcuarmjaocwegpbntumootrdzsnfmkrnfmupswvnbccqhbhrczxhwsycrjpnfotxibwebickebthawvxokhpmrmyhjzwqqoghlmykeofgjquvluoppyrkzptuykfrfzqwslczgogpvgircnvdjauned", 'm', "mxhqpckayglwqzadveinetromvtixnqpyacmpcmyofikvpogplcufhcfqsgzewqwlnscbzfryquplieorfuzfzekicwpkktnzsgxcuarmjaocwegpbntumootrdzsnfmkrnfmupswvnbccqhbhrczxhwsycrjpnfotxibwebickebthawvxokhpmrmyhjzwqqoghlmykeofgjquvluoppyrkzptuykfrfzqwslczgogpvgircnvdjauned")]
    public void ReversePrefix_GivenWordAndChar_ReturnsModifiedString(string word, char ch, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReversePrefix(word, ch);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}