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

using LeetCode.Algorithms.CouponCodeValidator;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CouponCodeValidator;

public abstract class CouponCodeValidatorTestsBase<T> where T : ICouponCodeValidator, new()
{
    [TestMethod]
    [DataRow("[\"SAVE20\",\"\",\"PHARMA5\",\"SAVE@20\"]", "[\"restaurant\",\"grocery\",\"pharmacy\",\"restaurant\"]",
        "[true,true,true,true]", "[\"PHARMA5\",\"SAVE20\"]")]
    [DataRow("[\"GROCERY15\",\"ELECTRONICS_50\",\"DISCOUNT10\"]", "[\"grocery\",\"electronics\",\"invalid\"]",
        "[false,true,true]", "[\"ELECTRONICS_50\"]")]
    public void ValidateCoupons_WithMixedCodesAndActiveFlags_ReturnsOnlyActiveValidCoupons(string codeJson,
        string businessLineJson, string isActiveJson, string expectedResultJson)
    {
        // Arrange
        var code = JsonHelper<string[]>.Parse(codeJson);
        var businessLine = JsonHelper<string[]>.Parse(businessLineJson);
        var isActive = JsonHelper<bool[]>.Parse(isActiveJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ValidateCoupons(code, businessLine, isActive).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}