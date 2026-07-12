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

namespace LeetCode.Algorithms.CouponCodeValidator;

/// <inheritdoc />
public sealed class CouponCodeValidatorBucketSort : ICouponCodeValidator
{
    private const int CategoryCount = 4;

    private static readonly Dictionary<string, int> CategoryToIndexDictionary =
        new() { ["electronics"] = 0, ["grocery"] = 1, ["pharmacy"] = 2, ["restaurant"] = 3 };

    /// <summary>
    ///     Time complexity - O(L + n log n), where L is the total characters in all codes
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="code"></param>
    /// <param name="businessLine"></param>
    /// <param name="isActive"></param>
    /// <returns></returns>
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var buckets = new List<string>[CategoryCount];

        for (var i = 0; i < buckets.Length; i++)
        {
            buckets[i] = [];
        }

        for (var i = 0; i < code.Length; i++)
        {
            if (!IsCouponValid(code[i], businessLine[i], isActive[i]))
            {
                continue;
            }

            var index = CategoryToIndexDictionary[businessLine[i]];

            buckets[index].Add(code[i]);
        }

        var result = new List<string>();

        for (var i = 0; i < buckets.Length; i++)
        {
            var bucket = buckets[i];

            if (bucket.Count == 0)
            {
                continue;
            }

            bucket.Sort(StringComparer.Ordinal);

            result.AddRange(bucket);
        }

        return result;
    }

    private static bool IsCouponValid(string code, string category, bool isActive)
    {
        if (!isActive)
        {
            return false;
        }

        if (!CategoryToIndexDictionary.ContainsKey(category))
        {
            return false;
        }

        if (string.IsNullOrEmpty(code))
        {
            return false;
        }

        for (var i = 0; i < code.Length; i++)
        {
            var c = code[i];

            if (char.IsLetterOrDigit(c) || c == '_')
            {
                continue;
            }

            return false;
        }

        return true;
    }
}