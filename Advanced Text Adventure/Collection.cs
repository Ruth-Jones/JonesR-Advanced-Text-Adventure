using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    internal class Collection
    {
        static void Collect()
        {
            // some basic variable types
            int x = 5;
            float y = 3.5f;
            string myString = "hi";
            char c = 'I';
            bool myBool = true;

            //Array. The size never changes.
            bool[] myBools = [true, false, false, true];
            myBools[0] = false;
            myBools[3] = false;
            Console.WriteLine(myBools[0]); //false

            //List. the size grows and shrinks as necceassary.
            List<bool> boolList = [false, true];
            boolList.Add(false);
            boolList.Add(true);
            boolList.Remove(true);
            Console.WriteLine(boolList[2]); //true

            // Stack. Grows and Shrinks. Last-in-fist-out
            Stack<string> myStack = new();
            myStack.Push("Help");
            myStack.Push(", ");
            myStack.Push("Please");

            Console.WriteLine(myStack.Pop()); // Please
            Console.WriteLine(myStack.Pop()); //, 
            Console.WriteLine(myStack.Peek()); // Help
            Console.WriteLine(myStack.Peek()); // Help
            Console.WriteLine(myStack.Pop());  // Help

            // Queue. Grows and Shrinks. first-in-first-out.

            Queue<string> myQueue = new();
            myQueue.Enqueue("Help");
            myQueue.Enqueue(", ");
            myQueue.Enqueue("Please");

            Console.WriteLine(myQueue.Dequeue()); //Help
            Console.WriteLine(myQueue.Dequeue()); //, 
            Console.WriteLine(myQueue.Peek()); //Please
            Console.WriteLine(myQueue.Peek()); //Please
            Console.WriteLine(myQueue.Dequeue()); //Please

            //Dictionary. stores a key-value collection. looks up a value given a key.
            Dictionary<string, int> myDictinary = new()
            {
                { "Joe", 71 },
                { "Joseph", 50 }
            };

            Console.WriteLine(myDictinary["Joe"]); //71
            Console.WriteLine(myDictinary["Joeseph"]); //50
        }
    }
}
