using System;
using System.Collections.Generic;

namespace Stack
{
    internal class ImplGenericStackList<T>
    {
        private List<T> _stackImplList = new List<T>();
        private int _pointer;

        // Inserts an object at the top of the ImplGenericStackList
        internal void Push(T item)
        {
            this._stackImplList.Add(item);
            MovePointer();
        }

        // Returns the object at the top of the Stack without removing it
        internal void Peek()
        {
            int item = this._stackImplList.Count > 0 ? this._pointer : default(int);

            Console.WriteLine($"PEEK: {item}\n");
        }

        // 	Removes and returns the object at the top of the Stack
        internal void Pop()
        {
            if (_stackImplList.Count > 0)
            {
                int item = this._pointer; // Remember the element to return
                this._stackImplList.RemoveAt(GetLastElement());
                MovePointer();

                Console.WriteLine($"POP: {item}\n");
            }
        }

        private void MovePointer()
        {
            this._pointer = _stackImplList.Count > 0 ? Convert.ToInt32(this._stackImplList[GetLastElement()]) : default(int);
        }

        private int GetLastElement()
        {
            return this._stackImplList.Count - 1;
        }

        internal void StackListLength()
        {
            Console.WriteLine($"Length: {this._stackImplList.Count}\n");
        }
    }
}
