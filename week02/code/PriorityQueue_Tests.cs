using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Two different values show that have a 5 and 5 priority and one after another.
    // Expected Result: Expected value should be Tim with a value priority of 5.
    // Defect(s) Found: The defect found was that the first priority would be overriden by the second. Created a list 
    // store the values and would call that with the first element in the index to return the value associated. So it returns the correct value.
    // Changed the value of the index to 0 also to start in order to fix some issues related to the indexing.
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 5);
        var sue = new PriorityItem("Sue", 5);
        var george = new PriorityItem("George", 3);
        var priorityQueue = new PriorityQueue();

        PriorityItem[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, sue, tim, tim];
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(george.Value, george.Priority);

        int i = 0;
        if (i >= expectedResult.Length)
        {
            Assert.Fail("Que should ran out");
        }
        Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: If the list is empty will the program still run
    // Expected Result: The result should return the are equal of The Queue is empty.
    // Defect(s) Found: No Defect Found works as needed.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("expection should show");

        }
        catch (InvalidOperationException f)
        {
            Assert.AreEqual("The queue is empty.", f.Message);
        }

    }

    // Add more test cases as needed below.
}