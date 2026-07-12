// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ImplementRouter;

/// <inheritdoc />
public sealed class ImplementRouterDictionaryWithBinarySearch : IImplementRouter
{
    private static readonly int[] ForwardBuffer = new int[3];
    private readonly Dictionary<int, TimestampBuffer> _destinationToTimestampBufferDictionary;
    private readonly int _memoryLimit;
    private readonly HashSet<(int Source, int Destination, int Timestamp)> _packetsHashSet;
    private readonly Queue<(int Source, int Destination, int Timestamp)> _packetsQueue;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="memoryLimit"></param>
    public ImplementRouterDictionaryWithBinarySearch(int memoryLimit)
    {
        _memoryLimit = memoryLimit;
        _packetsHashSet = new HashSet<(int Source, int Destination, int Timestamp)>(memoryLimit);
        _packetsQueue = new Queue<(int Source, int Destination, int Timestamp)>(memoryLimit);
        _destinationToTimestampBufferDictionary = new Dictionary<int, TimestampBuffer>(memoryLimit);
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="destination"></param>
    /// <param name="timestamp"></param>
    /// <returns></returns>
    public bool AddPacket(int source, int destination, int timestamp)
    {
        var packet = (source, destination, timestamp);

        if (!_packetsHashSet.Add(packet))
        {
            return false;
        }

        if (_packetsQueue.Count == _memoryLimit)
        {
            ForwardPacket();
        }

        _packetsQueue.Enqueue(packet);

        if (!_destinationToTimestampBufferDictionary.TryGetValue(destination, out var timestampBuffer))
        {
            timestampBuffer = new TimestampBuffer();

            _destinationToTimestampBufferDictionary[destination] = timestampBuffer;
        }

        timestampBuffer.Add(timestamp);

        return true;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <returns></returns>
    public int[] ForwardPacket()
    {
        if (_packetsQueue.Count == 0)
        {
            return [];
        }

        var packet = _packetsQueue.Dequeue();

        _packetsHashSet.Remove(packet);

        _destinationToTimestampBufferDictionary[packet.Destination].RemoveHead();

        return GetForwardBuffer(packet.Source, packet.Destination, packet.Timestamp);
    }

    /// <summary>
    ///     Time complexity - O(log m), where m is the number of timestamps for this destination
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="destination"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    public int GetCount(int destination, int startTime, int endTime)
    {
        return _destinationToTimestampBufferDictionary.TryGetValue(destination, out var packetBuffer)
            ? packetBuffer.GetCountInRange(startTime, endTime)
            : 0;
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="source"></param>
    /// <param name="destination"></param>
    /// <param name="timestamp"></param>
    /// <returns></returns>
    private static int[] GetForwardBuffer(int source, int destination, int timestamp)
    {
        ForwardBuffer[0] = source;
        ForwardBuffer[1] = destination;
        ForwardBuffer[2] = timestamp;

        return ForwardBuffer;
    }

    private class TimestampBuffer
    {
        private readonly List<int> _timestamps = [];
        private int _head;

        /// <summary>
        ///     Time complexity - O(1), O(n) in worst-case on resize
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="packet"></param>
        public void Add(int packet)
        {
            _timestamps.Add(packet);
        }

        /// <summary>
        ///     Time complexity - O(1)
        ///     Space complexity - O(1)
        /// </summary>
        public void RemoveHead()
        {
            _head++;
        }

        /// <summary>
        ///     Time complexity - O(log m), where m is the number of timestamps currently stored
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public int GetCountInRange(int startTime, int endTime)
        {
            if (_timestamps.Count - _head == 0)
            {
                return 0;
            }

            var packetsCount = _timestamps.Count;

            var left = FindLowerBound(startTime);
            var right = FindLowerBound(endTime + 1);

            if (left > right || left >= packetsCount)
            {
                return 0;
            }

            return right - left;
        }

        /// <summary>
        ///     Time complexity - O(log m), where m is the number of timestamps currently stored
        ///     Space complexity - O(1)
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int FindLowerBound(int target)
        {
            var low = _head;
            var high = _timestamps.Count;

            while (low < high)
            {
                var mid = low + ((high - low) / 2);

                if (_timestamps[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return high;
        }
    }
}