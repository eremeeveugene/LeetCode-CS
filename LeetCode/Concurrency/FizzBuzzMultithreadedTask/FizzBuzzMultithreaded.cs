namespace LeetCode.Concurrency.FizzBuzzMultithreadedTask;

public class FizzBuzzMultithreaded
{
    private readonly int _length;
    private readonly object _lock = new();
    private int _number = 1;

    public FizzBuzzMultithreaded(int length)
    {
        _length = length;
    }

    public void Fizz(Action printFizz)
    {
        lock (_lock)
        {
            while (_number <= _length)
            {
                while (_number <= _length && (_number % 3 != 0 || _number % 5 == 0))
                {
                    Monitor.Wait(_lock);

                    if (_number > _length) return;
                }

                printFizz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Buzz(Action printBuzz)
    {
        lock (_lock)
        {
            while (_number <= _length)
            {
                while (_number % 3 == 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _length) return;
                }

                printBuzz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Fizzbuzz(Action printFizzBuzz)
    {
        lock (_lock)
        {
            while (_number <= _length)
            {
                while (_number % 3 != 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _length) return;
                }

                printFizzBuzz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Number(Action<int> printNumber)
    {
        lock (_lock)
        {
            while (_number <= _length)
            {
                while (_number % 3 == 0 || _number % 5 == 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _length) return;
                }

                printNumber.Invoke(_number);

                IncrementNumber();
            }
        }
    }

    private void IncrementNumber()
    {
        _number++;

        Monitor.PulseAll(_lock);
    }
}