namespace LeetCode.Algorithms.ImplementStackUsingQueues;

/// <summary>
///     https://leetcode.com/problems/implement-stack-using-queues/description/
/// </summary>
public interface IImplementStackUsingQueues
{
    void Push(int x);
    int Pop();
    int Top();
    bool Empty();
}