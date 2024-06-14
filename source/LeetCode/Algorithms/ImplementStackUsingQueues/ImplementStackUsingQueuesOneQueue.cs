namespace LeetCode.Algorithms.ImplementStackUsingQueues;

/// <inheritdoc />
public class ImplementStackUsingQueuesOneQueue : IImplementStackUsingQueues
{
    private readonly Queue<int> _queue = new();

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="x"></param>
    public void Push(int x)
    {
        var size = _queue.Count;

        _queue.Enqueue(x);

        for (var i = 0; i < size; i++)
        {
            _queue.Enqueue(_queue.Dequeue());
        }
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int Pop()
    {
        return _queue.Dequeue();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public int Top()
    {
        return _queue.Peek();
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <returns></returns>
    public bool Empty()
    {
        return _queue.Count == 0;
    }
}