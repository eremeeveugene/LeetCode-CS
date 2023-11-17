namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderManualResetEvent
{
    private readonly ManualResetEvent _firstPrint = new(false);
    private readonly ManualResetEvent _secondPrint = new(false);

    public void First(Action printFirst)
    {
        printFirst();

        _firstPrint.Set();
    }

    public void Second(Action printSecond)
    {
        _firstPrint.WaitOne();

        printSecond();

        _secondPrint.Set();
    }

    public void Third(Action printThird)
    {
        _secondPrint.WaitOne();

        printThird();
    }
}