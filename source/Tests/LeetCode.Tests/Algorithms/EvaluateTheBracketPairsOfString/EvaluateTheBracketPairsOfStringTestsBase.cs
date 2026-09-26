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

using LeetCode.Algorithms.EvaluateTheBracketPairsOfString;

namespace LeetCode.Tests.Algorithms.EvaluateTheBracketPairsOfString;

public abstract class EvaluateTheBracketPairsOfStringTestsBase<T> where T : IEvaluateTheBracketPairsOfString, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Evaluate_WithBracketedKeysAndKnowledge_ReturnsEvaluatedString(string s, IList<IList<string>> knowledge, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Evaluate(s, knowledge);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["(name)is(age)yearsold", new[] { new[] { "name", "bob" }, new[] { "age", "two" } }, "bobistwoyearsold"];
        yield return ["hi(name)", new[] { new[] { "a", "b" } }, "hi?"];
        yield return ["(a)(a)(a)aaa", new[] { new[] { "a", "yes" } }, "yesyesyesaaa"];
        yield return ["a", Array.Empty<string[]>(), "a"];
        yield return ["abcdefghijklmnopqrstuvwxyz", Array.Empty<string[]>(), "abcdefghijklmnopqrstuvwxyz"];
        yield return ["plain", new[] { new[] { "plain", "changed" } }, "plain"];
        yield return ["(a)", Array.Empty<string[]>(), "?"];
        yield return ["(a)", new[] { new[] { "a", "b" } }, "b"];
        yield return ["(abc)", new[] { new[] { "abc", "abcdefghij" } }, "abcdefghij"];
        yield return ["(abcdefghij)", new[] { new[] { "abcdefghij", "z" } }, "z"];
        yield return ["(a)(b)(c)", new[] { new[] { "a", "x" }, new[] { "b", "y" }, new[] { "c", "z" } }, "xyz"];
        yield return ["(a)(b)(c)", Array.Empty<string[]>(), "???"];
        yield return ["(a)(b)(c)", new[] { new[] { "a", "x" }, new[] { "c", "z" } }, "x?z"];
        yield return ["before(a)", new[] { new[] { "a", "after" } }, "beforeafter"];
        yield return ["(a)after", new[] { new[] { "a", "before" } }, "beforeafter"];
        yield return ["before(a)after", new[] { new[] { "a", "middle" } }, "beforemiddleafter"];
        yield return ["a(a)a", new[] { new[] { "a", "b" } }, "aba"];
        yield return ["(a)x(b)y(c)", new[] { new[] { "a", "one" }, new[] { "b", "two" }, new[] { "c", "three" } }, "onextwoythree"];
        yield return ["(missing)(missing)", new[] { new[] { "other", "value" } }, "??"];
        yield return ["(a)(ab)(abc)", new[] { new[] { "a", "one" }, new[] { "ab", "two" }, new[] { "abc", "three" } }, "onetwothree"];
        yield return ["(ab)", new[] { new[] { "a", "one" }, new[] { "abc", "three" } }, "?"];
        yield return ["(a)(b)", new[] { new[] { "a", "b" }, new[] { "b", "c" } }, "bc"];
        yield return ["(a)(a)", new[] { new[] { "a", "a" } }, "aa"];
        yield return ["(z)(a)", new[] { new[] { "a", "first" }, new[] { "z", "last" } }, "lastfirst"];
        yield return ["(a)(b)(c)", new[] { new[] { "c", "three" }, new[] { "b", "two" }, new[] { "a", "one" } }, "onetwothree"];
        yield return ["text(unknown)tail", new[] { new[] { "text", "x" }, new[] { "tail", "y" } }, "text?tail"];
        yield return ["(abcdefghijk)", new[] { new[] { "abcdefghij", "value" } }, "?"];
        yield return ["(abc)(cba)", new[] { new[] { "abc", "same" }, new[] { "cba", "same" } }, "samesame"];
        yield return ["(a)and(b)", new[] { new[] { "unused", "ignored" }, new[] { "a", "yes" }, new[] { "b", "no" } }, "yesandno"];
        yield return ["x(a)y(b)z(c)end", new[] { new[] { "b", "known" } }, "x?yknownz?end"];

        yield return [new string('a', 1023), Array.Empty<string[]>(), new string('a', 1023)];
        yield return [new string('a', 1024), Array.Empty<string[]>(), new string('a', 1024)];
        yield return [new string('a', 1025), Array.Empty<string[]>(), new string('a', 1025)];
        yield return [string.Concat(Enumerable.Repeat("(a)", 256)), new[] { new[] { "a", "zzzz" } }, new string('z', 1024)];
        yield return [string.Concat(Enumerable.Repeat("(a)", 256)) + "a", new[] { new[] { "a", "zzzz" } }, new string('z', 1024) + "a"];
        yield return [new string('a', 100000), Array.Empty<string[]>(), new string('a', 100000)];
        yield return ["(" + new string('a', 99998) + ")", new[] { new[] { "a", "value" } }, "?"];

        yield return [string.Concat(Enumerable.Repeat("(a)", 33333)) + "a", new[] { new[] { "a", "zzzzzzzzzz" } }, new string('z', 333330) + "a"];

        var knowledge = new string[100000][];

        for (var i = 0; i < knowledge.Length; i++)
        {
            var key = new string(
                [(char)('a' + (i / (26 * 26 * 26))), (char)('a' + (i / (26 * 26) % 26)), (char)('a' + (i / 26 % 26)), (char)('a' + (i % 26))]);

            knowledge[i] = [key, "value"];
        }

        yield return ["(" + knowledge[^1][0] + ")(aaaa)(zzzz)", knowledge, "valuevalue?"];
    }
}