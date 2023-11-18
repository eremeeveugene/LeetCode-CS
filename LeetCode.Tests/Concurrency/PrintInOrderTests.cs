using LeetCode.Concurrency.PrintInOrderTask;

namespace LeetCode.Tests.Concurrency;

[TestClass]
public class PrintInOrderTests
{
    private const string First = "first";
    private const string Second = "second";
    private const string Third = "third";
    private const string FirstSecondThird = First + Second + Third;

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_ThreadSleep_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderThreadSleep();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_ManualResetEvent_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderManualResetEvent();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_AutoResetEvent_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderAutoResetEvent();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_Monitor_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderMonitor();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_SemaphoreSlim_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderSemaphoreSlim();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 })]
    [DataRow(new[] { 2, 3, 1 })]
    [DataRow(new[] { 3, 1, 2 })]
    public async Task PrintInOrder_TaskCompletionSource_ExecutesActionsInSequentialOrderAsync(int[] nums)
    {
        // Arrange
        var expectedResult = FirstSecondThird;
        var actualResult = string.Empty;

        // Act
        var printInOrder = new PrintInOrderTaskCompletionSource();

        var tasks = new List<Task>();

        foreach (var num in nums)
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

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}