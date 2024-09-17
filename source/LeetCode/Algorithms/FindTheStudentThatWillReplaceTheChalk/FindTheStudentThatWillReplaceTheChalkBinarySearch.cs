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

namespace LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

/// <inheritdoc />
public class FindTheStudentThatWillReplaceTheChalkBinarySearch : IFindTheStudentThatWillReplaceTheChalk
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="chalk"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int ChalkReplacer(int[] chalk, int k)
    {
        var prefixSum = new long[chalk.Length];

        prefixSum[0] = chalk[0];

        for (var i = 1; i < prefixSum.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + chalk[i];
        }

        return GetStudentIndex(prefixSum, k % prefixSum[^1]);
    }

    private static int GetStudentIndex(long[] prefixSum, long remainder)
    {
        var left = 0;
        var right = prefixSum.Length - 1;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (prefixSum[mid] <= remainder)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return right;
    }
}