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

using LeetCode.Algorithms.LongestPalindrome;

namespace LeetCode.Tests.Algorithms.LongestPalindrome;

public abstract class LongestPalindromeTestsBase<T> where T : ILongestPalindrome, new()
{
    [TestMethod]
    [DataRow("", 0)]
    [DataRow("a", 1)]
    [DataRow("bb", 2)]
    [DataRow("ccc", 3)]
    [DataRow("abccccdd", 7)]
    [DataRow("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth", 983)]
    [DataRow("abc", 1)]
    [DataRow("ab", 1)]
    [DataRow("aA", 1)]
    [DataRow("Aa", 1)]
    [DataRow("aaaa", 4)]
    [DataRow("aaaaa", 5)]
    [DataRow("aabbcc", 6)]
    [DataRow("aabbccc", 7)]
    [DataRow("aabbcccd", 7)]
    [DataRow("aabbccd", 7)]
    [DataRow("z", 1)]
    [DataRow("zz", 2)]
    [DataRow("zzz", 3)]
    [DataRow("xyz", 1)]
    [DataRow("abccba", 6)]
    [DataRow("aaaabbbb", 8)]
    [DataRow("ABCabc", 1)]
    [DataRow("aabbccddeeff", 12)]
    [DataRow("aabbccddeeffG", 13)]
    public void LongestPalindrome_WithInputString_ReturnsLengthOfLongestBuildablePalindrome(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}