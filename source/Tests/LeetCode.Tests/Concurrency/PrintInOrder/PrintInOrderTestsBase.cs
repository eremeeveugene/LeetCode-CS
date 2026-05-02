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

using LeetCode.Concurrency.PrintInOrder;
using System.Text;

namespace LeetCode.Tests.Concurrency.PrintInOrder;

public abstract class PrintInOrderTestsBase<T> where T : IPrintInOrder, new()
{
    private const string ExpectedResult = First + Second + Third;
    private const string First = "first";
    private const string Second = "second";
    private const string Third = "third";

    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 3, 2 })]
    [DataRow(new[] { 2, 1, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    [DataRow(new[] { 3, 2, 1 })]
    public async Task PrintInOrderThreadSleep_ExecuteTasksInVariableOrder_ProducesConsistentOrderedOutput(int[] nums)
    {
        // Arrange
        var actualResult = new StringBuilder();

        var solution = new T();

        // Act
        List<Task> tasks = [];

        foreach (var num in nums)
        {
            switch (num)
            {
                case 1:
                    tasks.Add(Task.Run(() => solution.First(() => actualResult.Append(First)), TestContext.CancellationToken));
                    break;
                case 2:
                    tasks.Add(Task.Run(() => solution.Second(() => actualResult.Append(Second)), TestContext.CancellationToken));
                    break;
                case 3:
                    tasks.Add(Task.Run(() => solution.Third(() => actualResult.Append(Third)), TestContext.CancellationToken));
                    break;
            }
        }

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(ExpectedResult, actualResult.ToString());
    }
}