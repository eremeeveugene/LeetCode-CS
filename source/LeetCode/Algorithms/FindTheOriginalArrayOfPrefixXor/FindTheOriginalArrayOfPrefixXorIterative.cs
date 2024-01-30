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

namespace LeetCode.Algorithms.FindTheOriginalArrayOfPrefixXor;

/// <inheritdoc />
public class FindTheOriginalArrayOfPrefixXorIterative : IFindTheOriginalArrayOfPrefixXor
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="pref"></param>
    /// <returns></returns>
    public int[] FindArray(int[] pref)
    {
        if (pref.Length <= 1)
        {
            return pref;
        }

        var result = new int[pref.Length];

        result[0] = pref[0];

        for (var i = 1; i < pref.Length; i++)
        {
            result[i] = pref[i - 1] ^ pref[i];
        }

        return result;
    }
}