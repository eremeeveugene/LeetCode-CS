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

using LeetCode.Algorithms.PalindromePartitioning;

namespace LeetCode.Tests.Algorithms.PalindromePartitioning;

public abstract class PalindromePartitioningTestsBase<T> where T : IPalindromePartitioning, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Partition_GivenString_ReturnsAllPossiblePalindromicPartitions(string s, IList<IList<string>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Partition(s);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["a", new IList<string>[] { new[] { "a" } }];

        yield return ["aab", new IList<string>[] { new[] { "a", "a", "b" }, new[] { "aa", "b" } }];

        yield return ["b", new IList<string>[] { new[] { "b" } }];

        yield return ["ab", new IList<string>[] { new[] { "a", "b" } }];

        yield return ["aa", new IList<string>[] { new[] { "a", "a" }, new[] { "aa" } }];

        yield return ["aba", new IList<string>[] { new[] { "a", "b", "a" }, new[] { "aba" } }];

        yield return ["abc", new IList<string>[] { new[] { "a", "b", "c" } }];

        yield return ["aaa", new IList<string>[] { new[] { "a", "a", "a" }, new[] { "a", "aa" }, new[] { "aa", "a" }, new[] { "aaa" } }];

        yield return ["abba", new IList<string>[] { new[] { "a", "b", "b", "a" }, new[] { "a", "bb", "a" }, new[] { "abba" } }];

        yield return ["abcba", new IList<string>[] { new[] { "a", "b", "c", "b", "a" }, new[] { "a", "bcb", "a" }, new[] { "abcba" } }];

        yield return ["aabb", new IList<string>[] { new[] { "a", "a", "b", "b" }, new[] { "a", "a", "bb" }, new[] { "aa", "b", "b" }, new[] { "aa", "bb" } }];

        yield return ["abab", new IList<string>[] { new[] { "a", "b", "a", "b" }, new[] { "a", "bab" }, new[] { "aba", "b" } }];

        yield return ["cdd", new IList<string>[] { new[] { "c", "d", "d" }, new[] { "c", "dd" } }];

        yield return ["efe", new IList<string>[] { new[] { "e", "f", "e" }, new[] { "efe" } }];

        yield return ["aaaa", new IList<string>[] { new[] { "a", "a", "a", "a" }, new[] { "a", "a", "aa" }, new[] { "a", "aa", "a" }, new[] { "a", "aaa" }, new[] { "aa", "a", "a" }, new[] { "aa", "aa" }, new[] { "aaa", "a" }, new[] { "aaaa" } }];

        yield return ["racecar", new IList<string>[] { new[] { "r", "a", "c", "e", "c", "a", "r" }, new[] { "r", "a", "cec", "a", "r" }, new[] { "r", "aceca", "r" }, new[] { "racecar" } }];

        yield return ["noon", new IList<string>[] { new[] { "n", "o", "o", "n" }, new[] { "n", "oo", "n" }, new[] { "noon" } }];

        yield return ["zzzz", new IList<string>[] { new[] { "z", "z", "z", "z" }, new[] { "z", "z", "zz" }, new[] { "z", "zz", "z" }, new[] { "z", "zzz" }, new[] { "zz", "z", "z" }, new[] { "zz", "zz" }, new[] { "zzz", "z" }, new[] { "zzzz" } }];

        yield return ["abacaba", new IList<string>[] { new[] { "a", "b", "a", "c", "a", "b", "a" }, new[] { "a", "b", "a", "c", "aba" }, new[] { "a", "b", "aca", "b", "a" }, new[] { "a", "bacab", "a" }, new[] { "aba", "c", "a", "b", "a" }, new[] { "aba", "c", "aba" }, new[] { "abacaba" } }];

        yield return ["aabaa", new IList<string>[] { new[] { "a", "a", "b", "a", "a" }, new[] { "a", "a", "b", "aa" }, new[] { "a", "aba", "a" }, new[] { "aa", "b", "a", "a" }, new[] { "aa", "b", "aa" }, new[] { "aabaa" } }];

        yield return ["xyzzyx", new IList<string>[] { new[] { "x", "y", "z", "z", "y", "x" }, new[] { "x", "y", "zz", "y", "x" }, new[] { "x", "yzzy", "x" }, new[] { "xyzzyx" } }];

        yield return ["abcd", new IList<string>[] { new[] { "a", "b", "c", "d" } }];
    }
}