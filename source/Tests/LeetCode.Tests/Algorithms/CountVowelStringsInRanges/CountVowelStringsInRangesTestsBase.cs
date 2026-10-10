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

using LeetCode.Algorithms.CountVowelStringsInRanges;

namespace LeetCode.Tests.Algorithms.CountVowelStringsInRanges;

public abstract class CountVowelStringsInRangesTestsBase<T> where T : ICountVowelStringsInRanges, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void VowelStrings_WithWordsAndQueries_ModifiesWordsAccordingToQueries(string[] words, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.VowelStrings(words, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { "aba", "bcb", "ece", "aa", "e" }, new[] { new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 1 } }, new[] { 2, 3, 0 }];

        yield return [new[] { "a", "e", "i" }, new[] { new[] { 0, 2 }, new[] { 0, 1 }, new[] { 2, 2 } }, new[] { 3, 2, 1 }];

        yield return [new[] { "a" }, new[] { new[] { 0, 0 } }, new[] { 1 }];

        yield return [new[] { "b" }, new[] { new[] { 0, 0 } }, new[] { 0 }];

        yield return [new[] { "aba", "bcb" }, new[] { new[] { 0, 1 }, new[] { 0, 0 }, new[] { 1, 1 } }, new[] { 1, 1, 0 }];

        yield return [new[] { "a", "b", "e", "c", "i" }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 2, 2 }, new[] { 3, 3 } }, new[] { 3, 1, 1, 0 }];

        yield return [new[] { "aeiou", "uoiea", "xyz" }, new[] { new[] { 0, 2 }, new[] { 0, 1 }, new[] { 2, 2 } }, new[] { 2, 2, 0 }];

        yield return [new[] { "apple", "banana", "orange", "umbrella", "kiwi" }, new[] { new[] { 0, 4 }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 3 }, new[] { 3, 4 } }, new[] { 3, 1, 0, 2, 1 }];

        yield return [new[] { "ae", "ea", "oo", "uu", "ii" }, new[] { new[] { 0, 4 }, new[] { 2, 4 } }, new[] { 5, 3 }];

        yield return [new[] { "ab", "ba", "bb" }, new[] { new[] { 0, 2 } }, new[] { 0 }];

        yield return [new[] { "e", "e", "e", "e" }, new[] { new[] { 0, 3 }, new[] { 1, 2 }, new[] { 3, 3 }, new[] { 0, 0 } }, new[] { 4, 2, 1, 1 }];

        yield return [new[] { "zzz", "yyy", "xxx" }, new[] { new[] { 0, 2 }, new[] { 1, 1 } }, new[] { 0, 0 }];

        yield return [new[] { "idea", "ice", "oath", "ear", "eye", "ou" }, new[] { new[] { 0, 5 }, new[] { 1, 3 }, new[] { 2, 2 }, new[] { 4, 5 } }, new[] { 4, 1, 0, 2 }];

        yield return [new[] { "u", "ub", "bu", "bub" }, new[] { new[] { 0, 3 }, new[] { 1, 2 } }, new[] { 1, 0 }];

        yield return [new[] { "a", "a", "a", "a", "a", "a" }, new[] { new[] { 0, 5 }, new[] { 2, 4 }, new[] { 5, 5 } }, new[] { 6, 3, 1 }];

        yield return [new[] { "bcd", "fgh", "jkl", "mnp" }, new[] { new[] { 0, 3 }, new[] { 0, 0 } }, new[] { 0, 0 }];

        yield return [new[] { "aa", "bb", "ee", "cc", "ii", "dd", "oo" }, new[] { new[] { 0, 6 }, new[] { 1, 5 }, new[] { 3, 3 }, new[] { 0, 2 } }, new[] { 4, 2, 0, 2 }];

        yield return [new[] { "hello", "world", "abracadabra", "eagle" }, new[] { new[] { 0, 3 }, new[] { 2, 3 }, new[] { 3, 3 } }, new[] { 2, 2, 1 }];

        yield return [new[] { "oxo", "axa", "bxb" }, new[] { new[] { 0, 2 }, new[] { 0, 1 }, new[] { 2, 2 } }, new[] { 2, 2, 0 }];

        yield return [new[] { "quiet", "on", "under", "ice", "sky" }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 4, 4 }, new[] { 0, 0 } }, new[] { 1, 1, 0, 0 }];
    }
}