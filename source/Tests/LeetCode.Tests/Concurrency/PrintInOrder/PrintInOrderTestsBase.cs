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

using LeetCode.Concurrency.PrintInOrder;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Concurrency.PrintInOrder;

public abstract class PrintInOrderTestsBase<T> where T : IPrintInOrder, new()
{
    private const string First = "first";
    private const string Second = "second";
    private const string Third = "third";

    [TestMethod]
    [DataRow("[1, 2, 3]")]
    [DataRow("[2, 3, 1]")]
    [DataRow("[3, 1, 2]")]
    public async Task PrintInOrderThreadSleep_ExecuteTasksInVariableOrder_ProducesConsistentOrderedOutput(
        string numsJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        const string expectedResult = First + Second + Third;
        var actualResult = string.Empty;
        var printInOrder = new T();

        // Act
        List<Task> tasks = [];

        foreach (var num in nums)
        {
            switch (num)
            {
                case 1:
                    tasks.Add(Task.Run(() => printInOrder.First(() => actualResult += First)));
                    break;
                case 2:
                    tasks.Add(Task.Run(() => printInOrder.Second(() => actualResult += Second)));
                    break;
                case 3:
                    tasks.Add(Task.Run(() => printInOrder.Third(() => actualResult += Third)));
                    break;
            }
        }

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}