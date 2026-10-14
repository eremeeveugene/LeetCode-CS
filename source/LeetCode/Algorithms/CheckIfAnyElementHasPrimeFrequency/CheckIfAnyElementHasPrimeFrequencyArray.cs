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

namespace LeetCode.Algorithms.CheckIfAnyElementHasPrimeFrequency;

/// <inheritdoc />
public sealed class CheckIfAnyElementHasPrimeFrequencyArray : CheckIfAnyElementHasPrimeFrequencyBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public override bool CheckPrimeFrequency(int[] nums)
    {
        var frequencyArray = new int[Count];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            frequencyArray[num]++;
        }

        for (var i = 0; i < frequencyArray.Length; i++)
        {
            var frequency = frequencyArray[i];

            if (IsPrime(frequency))
            {
                return true;
            }
        }

        return false;
    }
}