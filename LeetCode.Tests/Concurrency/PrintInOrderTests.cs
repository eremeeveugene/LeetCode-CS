using LeetCode.Concurrency.PrintInOrderTask;

namespace LeetCode.Tests.Concurrency;

[TestClass]
public class PrintInOrderTests
{
    private string _actualResult = string.Empty;

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, "firstsecondthird")]
    [DataRow(new[] { 3, 2, 1 }, "firstsecondthird")]
    [DataRow(new[] { 2, 3, 1 }, "firstsecondthird")]
    public async Task PrintInOrderThreadSleep_ExecutesActionsInSequentialOrder(int[] nums, string expectedResult)
    {
        var printInOrder = new PrintInOrderThreadSleep();

        var tasks = new List<Task>();

        foreach (var num in nums)
            switch (num)
            {
                case 1:
                    tasks.Add(Task.Run(() => printInOrder.First(PrintFirst)));
                    break;
                case 2:
                    tasks.Add(Task.Run(() => printInOrder.Second(PrintSecond)));
                    break;
                case 3:
                    tasks.Add(Task.Run(() => printInOrder.Third(PrintThird)));
                    break;
            }

        await Task.WhenAll(tasks);

        Assert.AreEqual(expectedResult, _actualResult);
    }

    private void PrintFirst()
    {
        _actualResult += "first";
    }

    private void PrintSecond()
    {
        _actualResult += "second";
    }

    private void PrintThird()
    {
        _actualResult += "third";
    }
}