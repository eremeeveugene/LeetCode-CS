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

using LeetCode.Algorithms.ReverseString;

namespace LeetCode.Tests.Algorithms.ReverseString;

public abstract class ReverseStringTestsBase<T> where T : IReverseString, new()
{
    [TestMethod]
    [DataRow(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [DataRow(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    [DataRow(new[] { 'a' }, new[] { 'a' })]
    [DataRow(new[] { 'a', 'b' }, new[] { 'b', 'a' })]
    [DataRow(new[] { 'a', 'b', 'c' }, new[] { 'c', 'b', 'a' })]
    [DataRow(new[] { 'a', 'b', 'c', 'd' }, new[] { 'd', 'c', 'b', 'a' })]
    [DataRow(new[] { 'a', 'a' }, new[] { 'a', 'a' })]
    [DataRow(new[] { 'a', 'b', 'b', 'a' }, new[] { 'a', 'b', 'b', 'a' })]
    [DataRow(new[] { 'r', 'a', 'c', 'e', 'c', 'a', 'r' }, new[] { 'r', 'a', 'c', 'e', 'c', 'a', 'r' })]
    [DataRow(new[] { 'A' }, new[] { 'A' })]
    [DataRow(new[] { 'a', 'B' }, new[] { 'B', 'a' })]
    [DataRow(new[] { 'A', 'b', '1' }, new[] { '1', 'b', 'A' })]
    [DataRow(new[] { '1', '2', '3', '4', '5' }, new[] { '5', '4', '3', '2', '1' })]
    [DataRow(new[] { '!', '@', '#' }, new[] { '#', '@', '!' })]
    [DataRow(new[] { 'a', ' ', 'b' }, new[] { 'b', ' ', 'a' })]
    [DataRow(new[] { 'x', 'y', 'z', 'z', 'y', 'x' }, new[] { 'x', 'y', 'z', 'z', 'y', 'x' })]
    [DataRow(new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' }, new[] { 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' })]
    [DataRow(new[] { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' }, new[] { '!', 'd', 'l', 'r', 'o', 'W', ' ', ',', 'o', 'l', 'l', 'e', 'H' })]
    [DataRow(new[] { 'c', 'e', 'd', 'k', 'b', 'u', 'h', 'r', 'x', 'r', 'q', 'g', 'k', 'q', 'c', 't', 'p', 'd', 'u', 'x', 'p', 'y', 'b', 'm', 'g', 'r', 'n', 'w', 'w', 'q', 's', 'a', 'k', 's', 'm', 'm', 'k', 'z', 'g', 'd', 'g', 'd', 'c', 'm', 'l', 'g', 'n', 's', 'g', 'n' }, new[] { 'n', 'g', 's', 'n', 'g', 'l', 'm', 'c', 'd', 'g', 'd', 'g', 'z', 'k', 'm', 'm', 's', 'k', 'a', 's', 'q', 'w', 'w', 'n', 'r', 'g', 'm', 'b', 'y', 'p', 'x', 'u', 'd', 'p', 't', 'c', 'q', 'k', 'g', 'q', 'r', 'x', 'r', 'h', 'u', 'b', 'k', 'd', 'e', 'c' })]
    [DataRow(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, new[] { '9', '8', '7', '6', '5', '4', '3', '2', '1', '0' })]
    public void ReverseString_WithCharArray_ReversesArrayInPlace(char[] s, char[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.ReverseString(s);

        // Assert
        Assert.AreSequenceEqual(expectedResult, s);
    }
}