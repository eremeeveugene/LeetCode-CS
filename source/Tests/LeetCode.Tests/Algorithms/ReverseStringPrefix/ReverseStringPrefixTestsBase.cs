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

using LeetCode.Algorithms.ReverseStringPrefix;

namespace LeetCode.Tests.Algorithms.ReverseStringPrefix;

public abstract class ReverseStringPrefixTestsBase<T> where T : IReverseStringPrefix, new()
{
    [TestMethod]
    [DataRow("abcd", 2, "bacd")]
    [DataRow("xyz", 3, "zyx")]
    [DataRow("hey", 1, "hey")]
    [DataRow("a", 1, "a")]
    [DataRow("ab", 1, "ab")]
    [DataRow("ab", 2, "ba")]
    [DataRow("abc", 2, "bac")]
    [DataRow("abc", 3, "cba")]
    [DataRow("abcdef", 4, "dcbaef")]
    [DataRow("abcdef", 6, "fedcba")]
    [DataRow("abcdef", 5, "edcbaf")]
    [DataRow("aaaa", 3, "aaaa")]
    [DataRow("abba", 4, "abba")]
    [DataRow("abcde", 2, "bacde")]
    [DataRow("zyxw", 3, "xyzw")]
    [DataRow("racecar", 7, "racecar")]
    [DataRow("hello", 5, "olleh")]
    [DataRow("hello", 3, "lehlo")]
    [DataRow("viulafztrzlrxhmrlzpigutlfujlewxsxyobetuyuwlqqzfdsmjxzvtrffuxwgedokhrhclinguurlnghyzoruuftwgigifieefb", 100, "bfeeifigigwtfuurozyhgnlruugnilchrhkodegwxuffrtvzxjmsdfzqqlwuyuteboyxsxweljufltugipzlrmhxrlzrtzfaluiv")]
    [DataRow("dakwtmnogunocffvtiynbxonzcjlugmmxsdgoriureougwznxnedwzgtpfdmrnnktcarhlisuhbhpojikewviayndhtjtjlrtmin", 99, "imtrljtjthdnyaivwekijophbhusilhractknnrmdfptgzwdenxnzwguoeruirogdsxmmguljcznoxbnyitvffconugonmtwkadn")]
    public void ReversePrefix_WithKCharacters_ReversesFirstKCharactersOnly(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReversePrefix(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}