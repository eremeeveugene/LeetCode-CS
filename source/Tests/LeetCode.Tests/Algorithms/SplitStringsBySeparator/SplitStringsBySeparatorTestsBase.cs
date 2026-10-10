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

using LeetCode.Algorithms.SplitStringsBySeparator;

namespace LeetCode.Tests.Algorithms.SplitStringsBySeparator;

public abstract class SplitStringsBySeparatorTestsBase<T> where T : ISplitStringsBySeparator, new()
{
    [TestMethod]
    [DataRow(new[] { "one.two.three", "four.five", "six" }, '.', new[] { "one", "two", "three", "four", "five", "six" })]
    [DataRow(new[] { "$easy$", "$problem$" }, '$', new[] { "easy", "problem" })]
    [DataRow(new[] { "|||" }, '|', new string[] { })]
    [DataRow(new[] { "a.b" }, '.', new[] { "a", "b" })]
    [DataRow(new[] { "." }, '.', new string[] { })]
    [DataRow(new[] { "" }, '.', new string[] { })]
    [DataRow(new[] { "abc" }, '|', new[] { "abc" })]
    [DataRow(new[] { "a,b,c,d" }, ',', new[] { "a", "b", "c", "d" })]
    [DataRow(new[] { ",a,", ",,b,," }, ',', new[] { "a", "b" })]
    [DataRow(new[] { "#x#y", "z#", "#" }, '#', new[] { "x", "y", "z" })]
    [DataRow(new[] { "one@two", "three" }, '@', new[] { "one", "two", "three" })]
    [DataRow(new[] { "a$b$c", "d$e", "f$" }, '$', new[] { "a", "b", "c", "d", "e", "f" })]
    [DataRow(new[] { "no separators here" }, '.', new[] { "no separators here" })]
    [DataRow(new[] { "...a...b..." }, '.', new[] { "a", "b" })]
    [DataRow(new[] { "||a||", "b|c" }, '|', new[] { "a", "b", "c" })]
    [DataRow(new[] { "x" }, 'x', new string[] { })]
    [DataRow(new[] { "xx", "xyx", "yxy" }, 'x', new[] { "y", "y", "y" })]
    [DataRow(new[] { "a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t" }, '.', new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t" })]
    [DataRow(new[] { "a.b.", ".c" }, '.', new[] { "a", "b", "c" })]
    [DataRow(new[] { "q", "w" }, 'e', new[] { "q", "w" })]
    [DataRow(new[] { "e.e" }, '.', new[] { "e", "e" })]
    public void SplitWordsBySeparator_WithStringsContainingSeparator_RemovesSeparatorAndExcludesEmptyStrings(
        string[] words,
        char separator,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SplitWordsBySeparator(words, separator);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}