namespace LeetCode.Algorithms.ImplementQueueUsingStacks;

/// <summary>
///     https://leetcode.com/problems/implement-queue-using-stacks/description/
/// </summary>
public interface IImplementQueueUsingStacks
{
    void Push(int x);

    int Pop();

    int Peek();

    bool Empty();
}