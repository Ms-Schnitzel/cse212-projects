using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items {string green, int 2} {string blue, int 1} {string red, int 3} with Enqueue and Dequeue in proper order 
    // Expected Result: red, gree, blue
    // Defect(s) Found: returns first item enqueued, not highest priority item. Was not evaluating last index item based on index < queue length - 1, removing -1 fixed issue.  Was returning last item with highest priority based on highPriorityIndex >= index, changing >= to just > fixed issue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // var green = new PriorityItem("green", 2);
        // var blue = new PriorityItem("blue", 1);
        // var red = new PriorityItem("red", 3);

        string expectedResult = "red";
        priorityQueue.Enqueue("green", 2);
        priorityQueue.Enqueue("blue", 3);
        priorityQueue.Enqueue("red", 5);
        priorityQueue.Enqueue("purple", 4);
        priorityQueue.Enqueue("orange", 5);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, result);
        
    }

    [TestMethod]
    // Scenario: Repeated calling should remove the highest priority item each time giving the next highest number until last number is lowest priority "green"
    // Expected Result: Error message "The queue is empty."
    // Defect(s) Found: Dequeue method is returning highest priority item but not removing it from queue. Including queue RemoveAt solved issue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var expectedResult = "green";

        priorityQueue.Enqueue("green", 1);
        priorityQueue.Enqueue("blue", 3);
        priorityQueue.Enqueue("red", 5);
        priorityQueue.Enqueue("purple", 4);
        priorityQueue.Enqueue("orange", 5);

        var result1 = priorityQueue.Dequeue();
        if (result1 != "red")
        {
            Assert.Fail("First high priority does not match");
        }
        var result2 = priorityQueue.Dequeue();
        if (result2 != "orange")
        {
            Assert.Fail("Second high priority does not match");
        }
        var result3 = priorityQueue.Dequeue();
        if (result3 != "purple")
        {
            Assert.Fail("Third high priority does not match");
        }
        var result4 = priorityQueue.Dequeue();
        if (result4 != "blue")
        {
            Assert.Fail("Fourth high priority does not match");
        }
        var result5 = priorityQueue.Dequeue();
        if (result5 != "green")
        {
            Assert.Fail("Fifth high priority does not match");
        }
        
        Assert.AreEqual(expectedResult, result5);
    }


    [TestMethod]
    // Scenario: Repeated calling should remove the highest priority item each time until the queue is empty.  Empty queue should return invalid operation exception error
    // Expected Result: Error message "The queue is empty."
    // Defect(s) Found: Dequeue method is returning highest priority item but not removing it from queue. Including queue RemoveAt solved issue
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        var expectedResult = "The queue is empty.";

        priorityQueue.Enqueue("green", 2);
        priorityQueue.Enqueue("orange", 1);

        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        var result = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual(expectedResult, result.Message);
    }

    // Add more test cases as needed below.
}