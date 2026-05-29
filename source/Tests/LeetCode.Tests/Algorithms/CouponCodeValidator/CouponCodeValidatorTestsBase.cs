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
    [DataRow(new[] { "SAVE20", "", "PHARMA5", "SAVE@20" }, new[] { "restaurant", "grocery", "pharmacy", "restaurant" },
        new[] { true, true, true, true }, new[] { "PHARMA5", "SAVE20" })]
    [DataRow(new[] { "GROCERY15", "ELECTRONICS_50", "DISCOUNT10" }, new[] { "grocery", "electronics", "invalid" },
        new[] { false, true, true }, new[] { "ELECTRONICS_50" })]
    public void ValidateCoupons_WithMixedCodesAndActiveFlags_ReturnsOnlyActiveValidCoupons(string[] code,
        string[] businessLine, bool[] isActive, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidateCoupons(code, businessLine, isActive).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}