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

namespace LeetCode.Algorithms.TwoOutOfThree;

/// <inheritdoc />
public sealed class TwoOutOfThreeFrequencyArray : ITwoOutOfThree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <param name="nums3"></param>
    /// <returns></returns>
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var frequencyArray = new int[100];

        foreach (var num1 in nums1)
        {
            var num1Index = num1 - 1;

            if (frequencyArray[num1Index] != 0)
            {
                continue;
            }

            frequencyArray[num1Index] = 1;
        }

        var result = new List<int>();

        foreach (var num2 in nums2)
        {
            var num2Index = num2 - 1;

            switch (frequencyArray[num2Index])
            {
                case 1:
                    result.Add(num2);

                    frequencyArray[num2Index] = -1;
                    break;
                case 0:
                    frequencyArray[num2Index] = 2;
                    break;
            }
        }

        foreach (var num3 in nums3)
        {
            var num3Index = num3 - 1;

            if (frequencyArray[num3Index] != 1 && frequencyArray[num3Index] != 2)
            {
                continue;
            }

            result.Add(num3);

            frequencyArray[num3Index] = -1;
        }

        return result;
    }
}