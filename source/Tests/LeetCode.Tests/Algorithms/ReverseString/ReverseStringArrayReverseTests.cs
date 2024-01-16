// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReverseString;

namespace LeetCode.Tests.Algorithms.ReverseString;

[TestClass]
public class ReverseStringArrayReverseTests
{
    [TestMethod]
    [DataRow(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [DataRow(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ReverseStringArrayReverse_ReverseString_WithCharArray_ReturnsReversedArray(char[] s,
        char[] expectedResult)
    {
        // Act
        ReverseStringArrayReverse.ReverseString(s);

        // Assert
        CollectionAssert.AreEqual(expectedResult, s);
    }
}