using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main1()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("Bir", 1);
        dictionary.Add("Iki", 2);
        dictionary.Add("Üç", 3);
        dictionary.Add("dort", 4);
        dictionary.Remove("Iki");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
    static public void Main2()
    {

        // Create a queue 
        // Using Queue class 
        Queue my_queue = new Queue();

        // Adding elements in Queue 
        // Using Enqueue() method 
        my_queue.Enqueue("GFG");
        my_queue.Enqueue(1);
        my_queue.Enqueue(100);
        my_queue.Enqueue(null);
        my_queue.Enqueue(2.4);
        my_queue.Enqueue("Geeks123");

        // Accessing the elements 
        // of my_queue Queue 
        // Using foreach loop 
        foreach (var ele in my_queue)
        {
            Console.WriteLine(ele);
        }
    }
    static public void Main3()
    {

        // Create a queue 
        // Using Queue class 
        Queue my_queue = new Queue();

        // Adding elements in Queue 
        // Using Enqueue() method 
        my_queue.Enqueue("GFG");
        my_queue.Enqueue("Geeks");
        my_queue.Enqueue("GeeksforGeeks");
        my_queue.Enqueue("geeks");
        my_queue.Enqueue("Geeks123");

        Console.WriteLine("Total elements present in my_queue: {0}",
        my_queue.Count);

        // Obtain the topmost element of my_queue 
        // Using Dequeue method 
        Console.WriteLine("Topmost element of my_queue"
+ " is: {0}", my_queue.Dequeue());


        Console.WriteLine("Total elements present in my_queue: {0}",
        my_queue.Count);

        // Obtain the topmost element of my_queue 
        // Using Peek method 
        Console.WriteLine("Topmost element of my_queue is: {0}",
my_queue.Peek());

        Console.WriteLine("Total elements present in my_queue: {0}",
        my_queue.Count);
    }
    static public void Main()
    {
        String[] strings = new string[3];
        strings[0] = "Baki";
        strings[0] = "Baki";
    }
}
