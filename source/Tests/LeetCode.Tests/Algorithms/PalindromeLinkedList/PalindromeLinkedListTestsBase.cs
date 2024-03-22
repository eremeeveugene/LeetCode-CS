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

using LeetCode.Algorithms.PalindromeLinkedList;
using LeetCode.Core.Extensions;

namespace LeetCode.Tests.Algorithms.PalindromeLinkedList;

public abstract class PalindromeLinkedListTestsBase<T> where T : IPalindromeLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 1 }, true)]
    [DataRow(new[] { 1, 2 }, false)]
    public void IsPalindrome_LinkedList_ReturnsTrueIfPalindromeFalseOtherwise(int[] headArray, bool expectedResult)
    {
        // Arrange
        var head = headArray.ToListNode();

        var solution = new T();

        // Act
        var actualResult = solution.IsPalindrome(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}