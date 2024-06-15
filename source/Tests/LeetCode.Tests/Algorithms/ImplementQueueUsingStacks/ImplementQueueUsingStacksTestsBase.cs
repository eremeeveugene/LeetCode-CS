using LeetCode.Algorithms.ImplementQueueUsingStacks;

namespace LeetCode.Tests.Algorithms.ImplementQueueUsingStacks;

public abstract class ImplementQueueUsingStacksTestsBase<T> where T : IImplementQueueUsingStacks, new()
{
    [TestMethod]
    public void Push_AddsElementToQueue_MakesQueueNonEmpty()
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Push(0);

        // Assert
        Assert.IsFalse(solution.Empty());
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 5, 10, 15 }, new[] { 5, 10, 15 })]
    [DataRow(new int[0], new int[0])]
    public void Pop_RemovesElementsFromQueue_QueueBecomesEmpty(int[] pushElements, int[] popExpected)
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

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 1)]
    [DataRow(new[] { 5, 10, 15 }, 5)]
    public void Peek_ReturnsFirstElementWithoutRemovingIt(int[] pushElements, int expectedPeek)
    {
        // Arrange
        var solution = new T();

        // Act
        foreach (var element in pushElements)
        {
            solution.Push(element);
        }

        // Assert
        Assert.AreEqual(expectedPeek, solution.Peek());
    }

    [TestMethod]
    public void Empty_WhenQueueIsEmpty_ReturnsTrue()
    {
        // Arrange
        var solution = new T();

        // Act & Assert
        Assert.IsTrue(solution.Empty());

        solution.Push(1);
        Assert.IsFalse(solution.Empty());

        solution.Pop();
        Assert.IsTrue(solution.Empty());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Pop_OnEmptyQueue_ThrowsInvalidOperationException()
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Peek_OnEmptyQueue_ThrowsInvalidOperationException()
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Peek();
    }
}