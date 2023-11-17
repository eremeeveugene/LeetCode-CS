namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderTaskCompletionSource
{
    private readonly TaskCompletionSource _firstPrint = new();
    private readonly TaskCompletionSource _secondPrint = new();

    public void First(Action printFirst)
    {
        printFirst();
        _firstPrint.SetResult();
    }

    public void Second(Action printSecond)
    {
        _firstPrint.Task.Wait();
        printSecond();
        _secondPrint.SetResult();
    }

    public void Third(Action printThird)
    {
        _secondPrint.Task.Wait();
        printThird();
    }
}