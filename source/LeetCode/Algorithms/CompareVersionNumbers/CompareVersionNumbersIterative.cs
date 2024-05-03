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

namespace LeetCode.Algorithms.CompareVersionNumbers;

/// <inheritdoc />
public class CompareVersionNumbersIterative : ICompareVersionNumbers
{
    /// <summary>
    ///     Time complexity - O(max(n,m)), where n and m are the lengths of version1 and version2 respectively
    ///     Space complexity - O(k+l), where k and l are the numbers of segments in the version strings
    /// </summary>
    /// <param name="version1"></param>
    /// <param name="version2"></param>
    /// <returns></returns>
    public int CompareVersion(string version1, string version2)
    {
        var version1Array = version1.Split('.');
        var version2Array = version2.Split('.');

        var i = 0;

        while (i < version1Array.Length || i < version2Array.Length)
        {
            var version1Number = 0;

            if (i < version1Array.Length)
            {
                version1Number = int.Parse(version1Array[i]);
            }

            var version2Number = 0;

            if (i < version2Array.Length)
            {
                version2Number = int.Parse(version2Array[i]);
            }

            if (version1Number > version2Number)
            {
                return 1;
            }

            if (version1Number < version2Number)
            {
                return -1;
            }

            i++;
        }

        return 0;
    }
}