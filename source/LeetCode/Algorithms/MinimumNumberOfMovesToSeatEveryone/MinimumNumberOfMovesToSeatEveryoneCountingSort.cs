namespace LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

/// <inheritdoc />
public class MinimumNumberOfMovesToSeatEveryoneCountingSort : IMinimumNumberOfMovesToSeatEveryone
{
    /// <summary>
    ///     Time complexity - O(n + maxPosition)
    ///     Space complexity - O(maxPosition)
    /// </summary>
    /// <param name="seats"></param>
    /// <param name="students"></param>
    /// <returns></returns>
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        var maxPosition = Math.Max(seats.Max(), students.Max());

        var differences = new int[maxPosition];

        foreach (var seat in seats)
        {
            differences[seat - 1]++;
        }

        foreach (var student in students)
        {
            differences[student - 1]--;
        }

        var moves = 0;
        var unmatched = 0;

        foreach (var difference in differences)
        {
            moves += Math.Abs(unmatched);

            unmatched += difference;
        }

        return moves;
    }
}