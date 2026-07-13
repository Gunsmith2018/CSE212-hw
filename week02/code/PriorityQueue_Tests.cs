using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: <[A(pri:1), B(pri:2), C(pri:3)]>
    // Defect(s) Found: <[A (Pri:1), B (Pri:2), C (Pri:3)]>

    public void TestPriorityQueue_1() // enqueue test
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.ToString();
        Assert.AreEqual("[A(pri:1), B(pri:2), C(pri:3)]",result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: High
    // Defect(s) Found: Low
    public void TestPriorityQueue_2() // dequeue test
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("High", result);
    }
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("High1", 20);
        priorityQueue.Enqueue("High2", 20);
        priorityQueue.Enqueue("High3", 20);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High1", result);

    }
    

    // Add more test cases as needed below.
}