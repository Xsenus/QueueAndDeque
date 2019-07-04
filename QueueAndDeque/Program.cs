using QueueAndDeque.Model;
using System;

namespace QueueAndDeque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DuplexLinkedDeque");

            var duplexLinkedDeque = new DuplexLinkedDeque<int>();
            duplexLinkedDeque.PushFront(1);
            duplexLinkedDeque.PushFront(2);
            duplexLinkedDeque.PushFront(3);
            duplexLinkedDeque.PushBack(4);
            duplexLinkedDeque.PushBack(5);

            Console.WriteLine($"Count: {duplexLinkedDeque.Count}");

            Console.WriteLine($"PopFront: {duplexLinkedDeque.PopFront()}");
            Console.WriteLine($"PopFront: {duplexLinkedDeque.PopFront()}");
            Console.WriteLine($"PopBack: {duplexLinkedDeque.PopBack()}");
            Console.WriteLine($"PopBack: {duplexLinkedDeque.PopBack()}");
            //Console.WriteLine($"PopFront: {duplexLinkedDeque.PopFront()}");
            Console.WriteLine($"PopFront: {duplexLinkedDeque.PopBack()}");


            Console.WriteLine("\nEasyDeque");

            var easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(4);
            easyDeque.PushBack(5);
            easyDeque.PushFront(6);
            easyDeque.PushBack(7);
            //easyDeque.PuchFront(1);
            //easyDeque.PuchFront(2);
            //easyDeque.PuchFront(3);
            //easyDeque.PushBack(40);
            //easyDeque.PushBack(50);
            //easyDeque.PuchFront(600);
            //easyDeque.PushBack(700);

            Console.WriteLine($"Count: {easyDeque.Count}");

            Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            //Console.WriteLine($"PopBack: {easyDeque.PopBack()}");
            //Console.WriteLine($"PopFront: {easyDeque.PopFront()}");
            //Console.WriteLine($"PopBack: {easyDeque.PopBack()}");

            Console.WriteLine("\nLinkedQueue");

            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            Console.WriteLine($"Count: {linkedQueue.Count}");

            Console.WriteLine($"Dequeue: {linkedQueue.Dequeue()}");
            Console.WriteLine($"Peek: {linkedQueue.Peek()}");
            Console.WriteLine($"Dequeue: {linkedQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {linkedQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {linkedQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {linkedQueue.Dequeue()}");

            Console.WriteLine("\nArrayQueue");

            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine($"Count: {arrayQueue.Count}");

            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
            Console.WriteLine($"Peek: {arrayQueue.Peek()}");
            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");

            Console.WriteLine("Когда очередь заканчивает, вытаскивает последний элемент:");
            Console.WriteLine($"Dequeue: {arrayQueue.Dequeue()}");

            Console.WriteLine("\nEasyQueue");

            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine($"Count: {easyQueue.Count}");

            Console.WriteLine($"Dequeue: {easyQueue.Dequeue()}");
            Console.WriteLine($"Peek: {easyQueue.Peek()}");
            Console.WriteLine($"Dequeue: {easyQueue.Dequeue()}");

            Console.ReadLine();
        }
    }
}
