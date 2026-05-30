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

using LeetCode.Algorithms.ThreeConsecutiveOdds;

namespace LeetCode.Tests.Algorithms.ThreeConsecutiveOdds;

public abstract class ThreeConsecutiveOddsTestsBase<T> where T : IThreeConsecutiveOdds, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 6, 4, 1 }, false)]
    [DataRow(new[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
    public void ThreeConsecutiveOdds_WithIntegerArray_ReturnsTrueIfThreeConsecutiveOddsExist(int[] arr,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThreeConsecutiveOdds(arr);

        Assert.AreEqual(expectedResult, actualResult);
    }
}