namespace LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

/// <inheritdoc />
public class MinimumNumberOfMovesToSeatEveryoneSorting : IMinimumNumberOfMovesToSeatEveryone
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="seats"></param>
    /// <param name="students"></param>
    /// <returns></returns>
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);

        return seats.Select((t, i) => Math.Abs(t - students[i])).Sum();
    }
}