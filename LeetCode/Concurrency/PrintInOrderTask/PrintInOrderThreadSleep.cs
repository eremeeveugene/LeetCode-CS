namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderThreadSleep
{
    private const int ThreadTimeoutMs = 10;
    private bool _isFirstPrinted;
    private bool _isSecondPrinted;

    public void First(Action printFirst)
    {
        printFirst();

        _isFirstPrinted = true;
    }

    public void Second(Action printSecond)
    {
        while (!_isFirstPrinted) Thread.Sleep(ThreadTimeoutMs);

        printSecond();

        _isSecondPrinted = true;
    }

    public void Third(Action printThird)
    {
        while (!_isSecondPrinted) Thread.Sleep(ThreadTimeoutMs);

        printThird();
    }
}