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

using System.Text;

namespace LeetCode.Algorithms.FlipColumnsForMaximumNumberOfEqualRows;

/// <inheritdoc />
public sealed class FlipColumnsForMaximumNumberOfEqualRowsDictionary : IFlipColumnsForMaximumNumberOfEqualRows
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var patternDictionary = new Dictionary<string, int>();

        for (var i = 0; i < matrix.Length; i++)
        {
            var currentRow = matrix[i];
            var patternStringBuilder = new StringBuilder();

            for (var j = 0; j < currentRow.Length; j++)
            {
                var cell = currentRow[j];

                patternStringBuilder.Append(currentRow[0] == cell ? 'T' : 'F');
            }

            var rowPattern = patternStringBuilder.ToString();

            if (!patternDictionary.TryAdd(rowPattern, 1))
            {
                patternDictionary[rowPattern]++;
            }
        }

        var counts = new int[patternDictionary.Count];

        patternDictionary.Values.CopyTo(counts, 0);

        var maxCount = 0;

        for (var i = 0; i < counts.Length; i++)
        {
            maxCount = Math.Max(maxCount, counts[i]);
        }

        return maxCount;
    }
}