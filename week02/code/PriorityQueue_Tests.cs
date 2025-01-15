using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add one element to queue, then dequeue
    // Expected Result: The element matches since it's the same one
    // Defect(s) Found: None. Enqueue and Dequeue for one item works
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Diamond", 5);

        var dequeued = priorityQueue.Dequeue();
        Assert.AreEqual("Diamond", dequeued, "The item does not match"); 
    }

    [TestMethod]
    // Scenario: Add multiple elements with different priorities then dequeue them.
    // Expected Result: Elements dequeue in the correct order => highest one first
    // Defect(s) Found: *Was expecting Diamond to be first dequeued as it is highest priority. *Item wasn't dequeued properly
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Amethyst", 1);
        priorityQueue.Enqueue("Sapphire", 2);
        priorityQueue.Enqueue("Diamond", 3);

        Assert.AreEqual("Diamond", priorityQueue.Dequeue(), "Diamond");
        Assert.AreEqual("Sapphire", priorityQueue.Dequeue(), "Sapphire");
        Assert.AreEqual("Amethyst", priorityQueue.Dequeue(), "Amethyst");
    }

    [TestMethod]
    // Scenario: Adding many elements with 2 elements having the same high priority  
    // Expected Result: the high priority element closest to the front of queue gets dequeued first
    // Defect(s) Found: After fixing Dequeue(), no defects found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Amethyst", 1);
        priorityQueue.Enqueue("Sapphire", 2);
        priorityQueue.Enqueue("Diamond", 3);
        priorityQueue.Enqueue("Emerald", 2);
        priorityQueue.Enqueue("Ruby", 3);

        Assert.AreEqual("Diamond", priorityQueue.Dequeue(), "Diamond");
        Assert.AreEqual("Ruby", priorityQueue.Dequeue(), "Ruby");
        Assert.AreEqual("Sapphire", priorityQueue.Dequeue(), "Sapphire");
        Assert.AreEqual("Emerald", priorityQueue.Dequeue(), "Emerald");
        Assert.AreEqual("Amethyst", priorityQueue.Dequeue(), "Amethyst");
    }

    [TestMethod]
    // Scenario: Empty queue
    // Expected Result: Throw error
    // Defect(s) Found: Got test to throw exception, but still failed
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        
        void Action()
        {
            priorityQueue.Dequeue();
        }
        
        Assert.ThrowsException<InvalidOperationException>(Action);
    }

}