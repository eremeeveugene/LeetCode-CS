using LeetCode.Algorithms.ImplementStackUsingQueues;

namespace LeetCode.Tests.Algorithms.ImplementStackUsingQueues;

public abstract class ImplementStackUsingQueuesTestsBase<T> where T : IImplementStackUsingQueues, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 3, 3, 2)]
    [DataRow(new[] { 5, 10, 15, 20 }, 20, 20, 15)]
    [DataRow(new[] { 42 }, 42, 42, null)]
    public void PushPopTop_WithVariousElements_ReturnsExpectedTopAndPopValues(int[] pushElements, int topExpected,
        int popExpected, int? popAfterTopExpected)
    {
        // Arrange
        var solution = new T();

        // Act
        foreach (var element in pushElements)
        {
            solution.Push(element);
        }

        // Assert
        Assert.AreEqual(topExpected, solution.Top());
        Assert.AreEqual(popExpected, solution.Pop());

        if (popAfterTopExpected.HasValue)
        {
            Assert.AreEqual(popAfterTopExpected.Value, solution.Top());
        }
    }

    [TestMethod]
    public void Empty_WhenItemPushed_ReturnsFalse()
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Push(0);

        // Assert
        Assert.IsFalse(solution.Empty());
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 5, 10, 15 }, new[] { 15, 10, 5 })]
    [DataRow(new int[0], new int[0])]
    public void MultiplePushAndPop_WithVariousElements_ReturnsElementsInLIFOOrder(int[] pushElements, int[] popExpected)
    {
        // Arrange
        var solution = new T();

        // Act
        foreach (var element in pushElements)
        {
            solution.Push(element);
        }

        // Assert
        foreach (var expected in popExpected)
        {
            Assert.AreEqual(expected, solution.Pop());
        }

        Assert.IsTrue(solution.Empty());
    }
}