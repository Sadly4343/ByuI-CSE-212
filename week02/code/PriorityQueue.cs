using System.Runtime.CompilerServices;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        int highPriorityIndex = 0;
        int maxIndex = -1;
        List<int> priorityNums = new List<int>();
        for (int index = 0; index < _queue.Count; index++)
        {
            if (_queue[index].Priority > highPriorityIndex)
            {
                highPriorityIndex = _queue[index].Priority;
                maxIndex = index;
            }
        }

        if (maxIndex != -1)
        {
            var highValue = _queue[maxIndex];
            _queue.RemoveAt(maxIndex);

            _queue.Insert(0, highValue);
        }

        // Remove and return the item with the highest priority
        var value = _queue[0].Value;
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}