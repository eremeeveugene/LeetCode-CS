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
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.PalindromeLinkedList;

public abstract class PalindromeLinkedListTestsBase<T> where T : IPalindromeLinkedList, new()
{
    [TestMethod]
    [DataRow("[1,2,2,1]", true)]
    [DataRow("[1,2]", false)]
    [DataRow("[1]", true)]
    [DataRow("[1,1]", true)]
    [DataRow("[1,2,3,2,1]", true)]
    [DataRow("[1,2,3,4,5]", false)]
    [DataRow("[1,0,1]", true)]
    [DataRow("[1,2,3,4,3,2,1]", true)]
    [DataRow("[1,2,3,3,2,1]", true)]
    [DataRow("[1,2,2,3]", false)]
    [DataRow("[-1,-2,-2,-1]", true)]
    [DataRow("[0,0,0,0]", true)]
    [DataRow("[1,2,1,2]", false)]
    public void IsPalindrome_LinkedList_ReturnsTrueIfPalindromeFalseOtherwise(string headJsonArray, bool expectedResult)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsPalindrome(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}