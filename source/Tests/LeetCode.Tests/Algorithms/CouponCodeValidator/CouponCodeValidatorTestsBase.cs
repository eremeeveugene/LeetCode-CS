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

using LeetCode.Algorithms.CouponCodeValidator;

namespace LeetCode.Tests.Algorithms.CouponCodeValidator;

public abstract class CouponCodeValidatorTestsBase<T> where T : ICouponCodeValidator, new()
{
    [TestMethod]
    [DataRow(
        new[] { "SAVE20", "", "PHARMA5", "SAVE@20" },
        new[] { "restaurant", "grocery", "pharmacy", "restaurant" },
        new[] { true, true, true, true },
        new[] { "PHARMA5", "SAVE20" })]
    [DataRow(
        new[] { "GROCERY15", "ELECTRONICS_50", "DISCOUNT10" },
        new[] { "grocery", "electronics", "invalid" },
        new[] { false, true, true },
        new[] { "ELECTRONICS_50" })]
    [DataRow(
        new[] { "A" },
        new[] { "electronics" },
        new[] { true },
        new[] { "A" })]
    [DataRow(
        new[] { "A" },
        new[] { "electronics" },
        new[] { false },
        new string[] { })]
    [DataRow(
        new[] { "A" },
        new[] { "unknown" },
        new[] { true },
        new string[] { })]
    [DataRow(
        new[] { "" },
        new[] { "grocery" },
        new[] { true },
        new string[] { })]
    [DataRow(
        new[] { "ab-c" },
        new[] { "pharmacy" },
        new[] { true },
        new string[] { })]
    [DataRow(
        new[] { "b", "a" },
        new[] { "restaurant", "restaurant" },
        new[] { true, true },
        new[] { "a", "b" })]
    [DataRow(
        new[] { "x1", "x2", "x3", "x4" },
        new[] { "restaurant", "pharmacy", "grocery", "electronics" },
        new[] { true, true, true, true },
        new[] { "x4", "x3", "x2", "x1" })]
    [DataRow(
        new[] { "B", "a", "A", "b" },
        new[] { "grocery", "grocery", "grocery", "grocery" },
        new[] { true, true, true, true },
        new[] { "A", "B", "a", "b" })]
    [DataRow(
        new[] { "_x", "x_", "9z", "Z9", "z_9" },
        new[] { "electronics", "electronics", "electronics", "electronics", "electronics" },
        new[] { true, true, true, true, true },
        new[] { "9z", "Z9", "_x", "x_", "z_9" })]
    [DataRow(
        new[] { "ok", "bad code", "bad$", "fine_1" },
        new[] { "pharmacy", "pharmacy", "pharmacy", "pharmacy" },
        new[] { true, true, true, true },
        new[] { "fine_1", "ok" })]
    [DataRow(
        new[] { "one", "two", "three" },
        new[] { "Grocery", "GROCERY", "grocery" },
        new[] { true, true, true },
        new[] { "three" })]
    [DataRow(
        new[] { "aa", "bb", "cc" },
        new[] { "electronics", "grocery", "pharmacy" },
        new[] { false, false, false },
        new string[] { })]
    [DataRow(
        new[] { "SAVE10", "SAVE5", "SAVE20" },
        new[] { "restaurant", "restaurant", "restaurant" },
        new[] { true, true, true },
        new[] { "SAVE10", "SAVE20", "SAVE5" })]
    [DataRow(
        new[] { "code1", "code2", "code3", "code4", "code5" },
        new[] { "restaurant", "electronics", "pharmacy", "grocery", "restaurant" },
        new[] { true, false, true, true, true },
        new[] { "code4", "code3", "code1", "code5" })]
    [DataRow(
        new[] { "0", "00", "000" },
        new[] { "pharmacy", "pharmacy", "pharmacy" },
        new[] { true, true, true },
        new[] { "0", "00", "000" })]
    [DataRow(
        new[] { "A1", "a1", "_1", "11" },
        new[] { "grocery", "grocery", "grocery", "grocery" },
        new[] { true, true, true, true },
        new[] { "11", "A1", "_1", "a1" })]
    [DataRow(
        new[] { "ELEC", "GROC", "PHAR", "REST" },
        new[] { "electronics", "grocery", "pharmacy", "restaurant" },
        new[] { true, true, true, true },
        new[] { "ELEC", "GROC", "PHAR", "REST" })]
    [DataRow(
        new[] { "a.b", "a,b", "a b", "a!b", "a_b" },
        new[] { "electronics", "electronics", "electronics", "electronics", "electronics" },
        new[] { true, true, true, true, true },
        new[] { "a_b" })]
    public void ValidateCoupons_WithMixedCodesAndActiveFlags_ReturnsOnlyActiveValidCoupons(
        string[] code,
        string[] businessLine,
        bool[] isActive,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidateCoupons(code, businessLine, isActive);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}