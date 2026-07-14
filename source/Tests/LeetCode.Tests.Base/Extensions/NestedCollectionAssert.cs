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

namespace LeetCode.Tests.Base.Extensions;

public static class NestedCollectionAssert
{
    public static void AreEquivalent<T>(IEnumerable<IEnumerable<T>> expectedResult, IEnumerable<IEnumerable<T>> actualResult)
    {
        ArgumentNullException.ThrowIfNull(expectedResult);
        ArgumentNullException.ThrowIfNull(actualResult);

        var expectedList = expectedResult.Select(sublist => sublist.OrderBy(x => x).ToArray()).OrderBy(sublist => string.Join(",", sublist)).ToList();

        var actualList = actualResult.Select(sublist => sublist.OrderBy(x => x).ToArray()).OrderBy(sublist => string.Join(",", sublist)).ToList();

        Assert.HasCount(expectedList.Count, actualList, "The number of sublists is different.");

        for (var i = 0; i < expectedList.Count; i++)
        {
            CollectionAssert.AreEquivalent(expectedList[i], actualList[i], $"Sublist at index {i} is different.");
        }
    }
}