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

using System.Text;

namespace LeetCode.Algorithms.FlipColumnsForMaximumNumberOfEqualRows;

/// <inheritdoc />
public class FlipColumnsForMaximumNumberOfEqualRowsDictionary : IFlipColumnsForMaximumNumberOfEqualRows
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var patternDictionary = new Dictionary<string, int>();

        foreach (var currentRow in matrix)
        {
            var patternStringBuilder = new StringBuilder();

            foreach (var cell in currentRow)
            {
                patternStringBuilder.Append(currentRow[0] == cell ? 'T' : 'F');
            }

            var rowPattern = patternStringBuilder.ToString();

            if (!patternDictionary.TryAdd(rowPattern, 1))
            {
                patternDictionary[rowPattern]++;
            }
        }

        return patternDictionary.Values.Max();
    }
}