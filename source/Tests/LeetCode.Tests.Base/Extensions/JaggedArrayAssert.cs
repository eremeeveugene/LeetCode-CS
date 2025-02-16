// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Tests.Base.Extensions;

[ExcludeFromCodeCoverage]
public static class JaggedArrayAssert
{
    public static void AreEqual<T>(IEnumerable<IEnumerable<T>> expected, IEnumerable<IEnumerable<T>> actual)
    {
        ArgumentNullException.ThrowIfNull(expected);
        ArgumentNullException.ThrowIfNull(actual);

        var expectedList = expected.ToList();
        var actualList = actual.ToList();

        Assert.AreEqual(expectedList.Count, actualList.Count, "The number of sublists is different.");

        for (var i = 0; i < expectedList.Count; i++)
        {
            CollectionAssert.AreEqual(expectedList[i].ToArray(), actualList[i].ToArray(),
                $"Sublist at index {i} is different.");
        }
    }

    public static void AreEquivalent<T>(IEnumerable<IEnumerable<T>> expected, IEnumerable<IEnumerable<T>> actual)
    {
        ArgumentNullException.ThrowIfNull(expected);
        ArgumentNullException.ThrowIfNull(actual);

        var expectedList = expected
            .Select(sublist => sublist.OrderBy(x => x).ToArray())
            .OrderBy(sublist => string.Join(",", sublist))
            .ToList();

        var actualList = actual
            .Select(sublist => sublist.OrderBy(x => x).ToArray())
            .OrderBy(sublist => string.Join(",", sublist))
            .ToList();

        Assert.AreEqual(expectedList.Count, actualList.Count, "The number of sublists is different.");

        for (var i = 0; i < expectedList.Count; i++)
        {
            CollectionAssert.AreEquivalent(expectedList[i], actualList[i], $"Sublist at index {i} is different.");
        }
    }
}