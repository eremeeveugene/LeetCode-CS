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

namespace LeetCode.Algorithms.FruitIntoBaskets;

/// <inheritdoc />
public sealed class FruitIntoBasketsFrequencyDictionary : IFruitIntoBaskets
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int TotalFruit(int[] fruits)
    {
        var maximumNumberOfFruits = 0;

        var fruitsFrequencyDictionary = new Dictionary<int, int>();

        var left = 0;

        for (var right = 0; right < fruits.Length; right++)
        {
            fruitsFrequencyDictionary[fruits[right]] = fruitsFrequencyDictionary.GetValueOrDefault(fruits[right]) + 1;

            while (fruitsFrequencyDictionary.Count > 2)
            {
                if (fruitsFrequencyDictionary[fruits[left]] == 1)
                {
                    fruitsFrequencyDictionary.Remove(fruits[left]);
                }
                else
                {
                    fruitsFrequencyDictionary[fruits[left]]--;
                }

                left++;
            }

            maximumNumberOfFruits = Math.Max(maximumNumberOfFruits, right - left + 1);
        }

        return maximumNumberOfFruits;
    }
}