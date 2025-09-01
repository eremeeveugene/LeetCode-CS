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

using LeetCode.Algorithms.RestoreFinishingOrder;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RestoreFinishingOrder;

public abstract class RestoreFinishingOrderTestsBase<T> where T : IRestoreFinishingOrder, new()
{
    [TestMethod]
    [DataRow("[3,1,2,5,4]", "[1,3,4]", "[3,1,4]")]
    [DataRow("[1,4,5,3,2]", "[2,5]", "[5,2]")]
    public void RecoverOrder_WithFriendIdsInOrderArray_ReturnsFriendsInFinishingOrder(string ordersJson,
        string friendsJson, string expectedResultJson)
    {
        // Arrange
        var orders = JsonHelper<int[]>.Parse(ordersJson);
        var friends = JsonHelper<int[]>.Parse(friendsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.RecoverOrder(orders, friends);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}