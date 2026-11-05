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

namespace LeetCode.Algorithms.FindTheDistanceValueBetweenTwoArrays;

/// <inheritdoc />
public sealed class FindTheDistanceValueBetweenTwoArraysTwoPointers : IFindTheDistanceValueBetweenTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n + m log m), where n is the length of arr1 and m is the length of arr2
    ///     Space complexity - O(log n + log m)
    /// </remarks>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        var n = arr1.Length;
        var m = arr2.Length;

        Array.Sort(arr1);
        Array.Sort(arr2);

        var arr2Index = 0;

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var value = arr1[i];

            while (arr2Index < m && arr2[arr2Index] < value - d)
            {
                arr2Index++;
            }

            if (arr2Index < m && arr2[arr2Index] <= value + d)
            {
                continue;
            }

            result++;
        }

        return result;
    }
}