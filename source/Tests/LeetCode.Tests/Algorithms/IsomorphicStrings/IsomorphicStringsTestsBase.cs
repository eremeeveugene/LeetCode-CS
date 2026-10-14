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

using LeetCode.Algorithms.IsomorphicStrings;

namespace LeetCode.Tests.Algorithms.IsomorphicStrings;

public abstract class IsomorphicStringsTestsBase<T> where T : IIsomorphicStrings, new()
{
    [TestMethod]
    [DataRow("egg", "add", true)]
    [DataRow("foo", "bar", false)]
    [DataRow("paper", "title", true)]
    [DataRow("badc", "baba", false)]
    [DataRow("a", "a", true)]
    [DataRow("a", "b", true)]
    [DataRow("ab", "aa", false)]
    [DataRow("aa", "ab", false)]
    [DataRow("ab", "cd", true)]
    [DataRow("abab", "cdcd", true)]
    [DataRow("abab", "cddc", false)]
    [DataRow("abc", "bca", true)]
    [DataRow("aabb", "xxyy", true)]
    [DataRow("aabb", "xyxy", false)]
    [DataRow("abcdefg", "gfedcba", true)]
    [DataRow("abcabc", "xyzxyz", true)]
    [DataRow("abcabc", "xyzxyy", false)]
    [DataRow("13", "42", true)]
    [DataRow("11", "23", false)]
    [DataRow("a b", "c d", true)]
    [DataRow("a!b", "c?d", true)]
    [DataRow("ab", "a!", true)]
    [DataRow("!!", "aa", true)]
    [DataRow("Aa", "bb", false)]
    [DataRow("Aa", "bc", true)]
    [DataRow("iabeedcgigcfadegdhddgcjchhhdeadfadeieagcejjfhjeahebcafhagafadagchgbcghefdjegccihedgiaaibahehfjecfhdchbgbjhbiahefgcbidiiggcafjbacecicieijjdijbdcaidhbjchhecccchghacfbjecaafacedcgddfcjffgfdjeeeigccagbigc", "skloonmqsqmpknoqnrnnqmtmrrrnoknpknosokqmottprtokrolmkprkqkpknkqmrqlmqropntoqmmsronqskkslkrorptomprnmrlqltrlskropqmlsnssqqmkptlkmomsmsosttnstlnmksnrltmrrommmmrqrkmpltomkkpkmonmqnnpmtppqpntooosqmmkqlsqm", true)]
    [DataRow("iabeedcgigcfadegdhddgcjchhhdeadfadeieagcejjfhjeahebcafhagafadagchgbcghefdjegccihedgiaaibahehfjecfhdchbgbjhbiahefgcbidiiggcafjbacecicieijjdijbdcaidhbjchhecccchghacfbjecaafacedcgddfcjffgfdjeeeigccagbigc", "skloonmqsqmpknoqnrnnqmtmrrrnoknpknosokqmottprtokrolmkprkqkpknkqmrqlmqropntoqmmsronqskkslkrorptomprnmrlqltrlskropqmlsnssqqmkptlkmomsmsosttnstlnmksnrltmrrommmmrqrkmpltomkkpkmonmqnnpmtppqpntooosqmmkqlsqk", false)]
    public void IsIsomorphic_WithTwoStrings_ReturnsTrueIfCharactersCanBeMappedOneToOne(string s, string t, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsIsomorphic(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}