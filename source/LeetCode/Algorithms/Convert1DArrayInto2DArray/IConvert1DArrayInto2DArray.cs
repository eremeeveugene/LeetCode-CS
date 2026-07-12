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

namespace LeetCode.Algorithms.Convert1DArrayInto2DArray;

/// <summary>
///     https://leetcode.com/problems/convert-1d-array-into-2d-array/
/// </summary>
public interface IConvert1DArrayInto2DArray
{
    /// <summary>
    ///     Converts the 1-dimensional array <paramref name="original" /> into a 2-dimensional array with
    ///     <paramref name="m" /> rows and <paramref name="n" /> columns.
    /// </summary>
    /// <param name="original">The 1-dimensional array of elements to convert.</param>
    /// <param name="m">The number of rows in the resulting 2-dimensional array.</param>
    /// <param name="n">The number of columns in the resulting 2-dimensional array.</param>
    /// <returns>
    ///     The resulting <paramref name="m" /> by <paramref name="n" /> 2-dimensional array, or an empty array if the
    ///     conversion is not possible.
    /// </returns>
    int[][] Construct2DArray(int[] original, int m, int n);
}