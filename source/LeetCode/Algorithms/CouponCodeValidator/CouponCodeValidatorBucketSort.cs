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

namespace LeetCode.Algorithms.CouponCodeValidator;

/// <inheritdoc />
public class CouponCodeValidatorBucketSort : ICouponCodeValidator
{
    private static readonly Dictionary<string, int> CategoryIndex = new()
    {
        ["electronics"] = 0,
        ["grocery"] = 1,
        ["pharmacy"] = 2,
        ["restaurant"] = 3
    };

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
        var buckets = GetBuckets();

        for (var i = 0; i < code.Length; i++)
        {
            if (!IsCouponValid(code[i], businessLine[i], isActive[i], out var category))
            {
                continue;
            }

            buckets[category].Add(code[i]);
        }

        return CollectSortedResults(buckets);
    }

    private static List<string>[] GetBuckets()
    {
        var buckets = new List<string>[4];

        for (var i = 0; i < 4; i++)
        {
            buckets[i] = [];
        }

        return buckets;
    }

    private static bool IsCouponValid(string code, string category, bool isActive, out int categoryIndex)
    {
        categoryIndex = -1;

        if (!isActive)
        {
            return false;
        }

        if (!CategoryIndex.TryGetValue(category, out categoryIndex))
        {
            return false;
        }

        return !string.IsNullOrEmpty(code) && code.All(c => char.IsLetterOrDigit(c) || c == '_');
    }

    private static List<string> CollectSortedResults(List<string>[] buckets)
    {
        var result = new List<string>();

        for (var i = 0; i < 4; i++)
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
}