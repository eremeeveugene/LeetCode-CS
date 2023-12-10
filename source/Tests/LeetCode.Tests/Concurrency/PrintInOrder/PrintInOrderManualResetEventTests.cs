// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Concurrency.PrintInOrder;

namespace LeetCode.Tests.Concurrency.PrintInOrder;

[TestClass]
public class PrintInOrderManualResetEventTests : PrintInOrderTestsBase
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrderManualResetEvent_ExecutesTasksInOrder_ResultsInExpectedString(int[] nums)
    {
        // Arrange
        string expectedResult = FirstSecondThird;
        string actualResult = string.Empty;

        // Act
        PrintInOrderManualResetEvent printInOrder = new();

        List<Task> tasks = new();

        foreach (int num in nums)
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