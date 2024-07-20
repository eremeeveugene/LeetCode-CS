// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Tests.Base.Extensions;

public static class JaggedArrayAssert
{
    public static void AreEqual<T>(T[][] expected, T[][] actual)
    {
        Assert.AreEqual(expected.Length, actual.Length, "The number of sub lists is different.");

        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToArray(), actual[i].ToArray(), $"Sublist {i} is different.");
        }
    }

    public static void AreEquivalent<T>(T[][] expected, T[][] actual)
    {
        Assert.AreEqual(expected.Length, actual.Length, "The number of sub lists is different.");

        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEquivalent(expected[i].ToArray(), actual[i].ToArray(), $"Sublist {i} is different.");
        }
    }
}