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

/// <summary>
///     https://leetcode.com/problems/coupon-code-validator/description/
/// </summary>
public interface ICouponCodeValidator
{
    /// <summary>
    ///     Validates the coupons described by <paramref name="code" />, <paramref name="businessLine" />, and
    ///     <paramref name="isActive" />, and returns the valid, active coupon codes sorted by business line priority
    ///     and then lexicographically.
    /// </summary>
    /// <param name="code">The coupon code for each coupon.</param>
    /// <param name="businessLine">The business line associated with each coupon.</param>
    /// <param name="isActive">A value indicating whether each coupon is currently active.</param>
    /// <returns>The codes of the valid and active coupons, sorted by business line priority and then lexicographically.</returns>
    IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive);
}