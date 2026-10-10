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

using LeetCode.Algorithms.IncreasingDecreasingString;

namespace LeetCode.Tests.Algorithms.IncreasingDecreasingString;

public abstract class IncreasingDecreasingStringTestsBase<T> where T : IIncreasingDecreasingString, new()
{
    [TestMethod]
    [DataRow("aaaabbbbcccc", "abccbaabccba")]
    [DataRow("rat", "art")]
    [DataRow("a", "a")]
    [DataRow("z", "z")]
    [DataRow("aa", "aa")]
    [DataRow("ab", "ab")]
    [DataRow("ba", "ab")]
    [DataRow("zyx", "xyz")]
    [DataRow("abc", "abc")]
    [DataRow("aabb", "abba")]
    [DataRow("leetcode", "cdelotee")]
    [DataRow("spo", "ops")]
    [DataRow("aaaaa", "aaaaa")]
    [DataRow("zzzzza", "azzzzz")]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", "abcdefghijklmnopqrstuvwxyz")]
    [DataRow("mississippi", "impsspiissi")]
    [DataRow("banana", "abnnaa")]
    [DataRow("aabbccdd", "abcddcba")]
    [DataRow("xyzzyx", "xyzzyx")]
    [DataRow("diicddiegihiifjfgegabaieahcfje", "abcdefghijjihgfedcaadefgiieiii")]
    [DataRow("fhdahchaabjbcihaggdfbhicjfhhbihagiahiibieihafgibjjgiedhjhdiafheijhdifeehcigcbehacgbiiiejjhhhgaecgggf", "abcdefghijjihgfedcbaabcdefghijjihgfedcbaabcdefghijjihgfecbaabcefghijjihgebaaghiihgaghiihhiihhiihhihh")]
    [DataRow("kmsuvkronqxskptdaemgznibmyrkbqibkyajoctpxrzrelicxpqsahvynfxzzdsuxatqtxyfyspueeqrnngpboomcrbdjqcsgeuctqgyolhzzphcvcprgfzmgrhdfrcpxzpqaagakjjcfqzxjdeafbpxykcdyvzrxmjbuqnkvsbofbajpkbwrbnukgukpydsynpbjbvgaomuqffppvzycyuxnjztqydafmwjxohkyjyuusoubbhdynfblxgfwzjlzvggncmuvyluxjajhbhifkxdrdtpjaohtewdhinnhwvkhaywprbbiixuijargjjiwimwumuakrpfgsneulhxhdsirevnjwobacdtpyjvxljowiehcnyojxkkewwhlurdshhaxydytkjknudlfxhqlquxdsgzqpojgqkmhkhkfeoiqcwtcylsrhnqofrykzardsljgmogehqlatofiluakmizbaqrhznmgzbtnxahtbyplhiarlpo", "abcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuwxyzzyxutsrqponmlkjihgfdcbaabcdfghijklmnopqrsuxyzzyxurqponlkjihgfdcbaabdfghjknopqruxyzzyxurqponkjhgfdbaabdghjknopqruxyzyxurqpnkjhbaabhjkpruxyyxurpkjhbaabhjkxyykjhahjyh")]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
    public void SortString_WithUnsortedString_ReturnsSortedString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}