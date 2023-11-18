namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderSemaphoreSlim
{
    private static readonly SemaphoreSlim FirstPrint = new(0, 1);
    private static readonly SemaphoreSlim SecondPrint = new(0, 1);

    public void First(Action printFirst)
    {
        printFirst.Invoke();

        FirstPrint.Release();
    }

    public void Second(Action printSecond)
    {
        FirstPrint.Wait();

        printSecond.Invoke();

        SecondPrint.Release();
    }

    public void Third(Action printThird)
    {
        SecondPrint.Wait();

        printThird.Invoke();
    }
}