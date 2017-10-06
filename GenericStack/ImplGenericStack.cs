using System;

namespace Stack
{
    internal class ImplGenericStack<T>
    {
        private MyStack<T> _currentStackItem;

        // Inserts an object at the top of the ImplGenericStackList
        internal void Push(T item)
        {
            MyStack<T> newValue = new MyStack<T>(item);

            if (this._currentStackItem != null)
            {
                newValue.Previous = this._currentStackItem;
            }
            this._currentStackItem = newValue;  // <-- Move pointer at the newly created object
        }

        // Returns the object at the top of the Stack without removing it
        internal void Peek()
        {
            if (this._currentStackItem != null)
            {
                Console.WriteLine($"PEEK: {this._currentStackItem.Value}\n");
            }
            else
            {
                Console.WriteLine("PEEK failed: Stack is empty!\n");
            }
        }

        // 	Removes and returns the object at the top of the Stack
        internal void Pop()
        {
            if (this._currentStackItem != null)
            {
                var item = this._currentStackItem.Value;
                this._currentStackItem = this._currentStackItem.Previous;  // <-- Move pointer at the previous object

                Console.WriteLine($"POP: {item}\n");
            }
            else
            {
                Console.WriteLine("POP failed: Stack is empty!\n");
            }
        }

        internal void StackLength()
        {
            int counter = 0;
            var currentIteratedItem = this._currentStackItem;

            while (this._currentStackItem != null)
            {
                // Number of iterations
                counter++;

                if (currentIteratedItem.Previous == null)
                {
                    break;
                }

                // Countdown
                currentIteratedItem = currentIteratedItem.Previous;
            }

            Console.WriteLine($"Stack length: {counter}\n");
        }
    }
}
