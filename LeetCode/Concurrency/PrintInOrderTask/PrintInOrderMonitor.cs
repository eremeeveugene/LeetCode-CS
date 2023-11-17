namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderMonitor
{
    private readonly object _lock = new();
    private int _step = 1;

    public void First(Action printFirst)
    {
        lock (_lock)
        {
            printFirst();

            _step = 2;

            Monitor.PulseAll(_lock);
        }
    }

    public void Second(Action printSecond)
    {
        lock (_lock)
        {
            while (_step != 2)
                Monitor.Wait(_lock);

            printSecond();

            _step = 3;

            Monitor.PulseAll(_lock);
        }
    }

    public void Third(Action printThird)
    {
        lock (_lock)
        {
            while (_step != 3)
                Monitor.Wait(_lock);

            printThird();
        }
    }
}