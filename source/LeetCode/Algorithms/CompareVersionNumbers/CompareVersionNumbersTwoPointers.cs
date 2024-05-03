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
public class CompareVersionNumbersTwoPointers : ICompareVersionNumbers
{
    /// <summary>
    ///     Time complexity - O(max(n,m)), where n and m are the lengths of version1 and version2 respectively
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="version1"></param>
    /// <param name="version2"></param>
    /// <returns></returns>
    public int CompareVersion(string version1, string version2)
    {
        var version1Index = 0;
        var version2Index = 0;

        while (version1Index < version1.Length || version2Index < version2.Length)
        {
            int num1 = 0, num2 = 0;

            while (version1Index < version1.Length && version1[version1Index] != '.')
            {
                num1 = (num1 * 10) + (int)char.GetNumericValue(version1[version1Index]);

                version1Index++;
            }

            while (version2Index < version2.Length && version2[version2Index] != '.')
            {
                num2 = (num2 * 10) + (int)char.GetNumericValue(version2[version2Index]);

                version2Index++;
            }

            if (num1 > num2)
            {
                return 1;
            }

            if (num1 < num2)
            {
                return -1;
            }

            version1Index++;
            version2Index++;
        }

        return 0;
    }
}