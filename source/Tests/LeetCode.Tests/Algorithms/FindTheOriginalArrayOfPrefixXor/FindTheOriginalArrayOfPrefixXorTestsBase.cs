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

using LeetCode.Algorithms.FindTheOriginalArrayOfPrefixXor;

namespace LeetCode.Tests.Algorithms.FindTheOriginalArrayOfPrefixXor;

public abstract class FindTheOriginalArrayOfPrefixXorTestsBase<T> where T : IFindTheOriginalArrayOfPrefixXor, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 0, 3, 1 }, new[] { 5, 7, 2, 3, 2 })]
    [DataRow(new[] { 13 }, new[] { 13 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 1, 863857 }, new[] { 1, 863856 })]
    [DataRow(new[] { 0, 1 }, new[] { 0, 1 })]
    [DataRow(new[] { 237456, 237461, 237461 }, new[] { 237456, 5, 0 })]
    [DataRow(new[] { 1, 0, 0 }, new[] { 1, 1, 0 })]
    [DataRow(new[] { 10, 10, 11, 11 }, new[] { 10, 0, 1, 0 })]
    [DataRow(new[] { 324909, 686716, 686716, 686710, 686718 }, new[] { 324909, 954193, 0, 10, 8 })]
    [DataRow(new[] { 1, 3, 2, 3, 7, 7 }, new[] { 1, 2, 1, 1, 4, 0 })]
    [DataRow(new[] { 7, 6, 548183, 548182, 819803, 819802, 819802 }, new[] { 7, 1, 548177, 1, 319245, 1, 0 })]
    [DataRow(new[] { 0, 1, 2, 2, 12, 965514, 965509, 965519 }, new[] { 0, 1, 3, 0, 14, 965510, 15, 10 })]
    [DataRow(new[] { 944656, 944662, 493811, 493811, 493810, 505989, 505988, 505988, 17960, 17966 }, new[] { 944656, 6, 647909, 0, 1, 12407, 1, 0, 523948, 6 })]
    [DataRow(new[] { 12, 13, 12, 13, 12, 13, 13, 12, 761858, 761857, 761856, 761856 }, new[] { 12, 1, 1, 1, 1, 1, 0, 1, 761870, 3, 1, 0 })]
    [DataRow(new[] { 100722 }, new[] { 100722 })]
    [DataRow(new[] { 0, 1, 3, 3 }, new[] { 0, 1, 2, 0 })]
    [DataRow(new[] { 1, 1, 0, 0, 0 }, new[] { 1, 0, 1, 0, 0 })]
    [DataRow(new[] { 801867, 801861, 801870, 801870, 801871, 801858 }, new[] { 801867, 14, 11, 0, 1, 13 })]
    [DataRow(new[] { 11, 10, 99396 }, new[] { 11, 1, 99406 })]
    [DataRow(new[] { 2, 597358 }, new[] { 2, 597356 })]
    public void FindArray_WithPrefixXorArray_ReturnsOriginalArrayUsingInverseXorLogic(int[] pref, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindArray(pref);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}