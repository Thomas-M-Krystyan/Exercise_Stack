using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            SimulateGenericStackList();

            SimulateGenericStack();
        }

        #region Generic Stack List
        private static void SimulateGenericStackList()
        {
            ImplGenericStackList<int> genericStackList = new ImplGenericStackList<int>();

            List<int> itemsToPush = new List<int> { 5, 8, 20 };

            // ------------------------
            // PEAK   --> on empty list
            // ------------------------
            genericStackList.StackListLength();
            genericStackList.Peek();

            // ------------------------
            // PUSH
            // ------------------------
            StringBuilder newItems = new StringBuilder();
            foreach (var item in itemsToPush)
            {
                genericStackList.Push(item);
                newItems.Append($"{item} ");
            }
            Console.WriteLine($"PUSH: {newItems}\n");
            genericStackList.StackListLength();

            // ------------------------
            // PEEK + POP
            // ------------------------
            for (int i = 0; i < itemsToPush.Count; i++)
            {
                genericStackList.Peek();
                genericStackList.Pop();
                genericStackList.StackListLength();
            }

            // ------------------------
            // POP    --> on empty list
            // ------------------------
            genericStackList.Pop();

            Console.ReadLine();
        }
        #endregion

        #region Generic Stack
        private static void SimulateGenericStack()
        {
            ImplGenericStack<int> genericStack = new ImplGenericStack<int>();

            List<int> itemsToPush = new List<int> { 5, 8, 20 };

            // ---------------------------
            // The generic stack is empty
            // ---------------------------
            genericStack.StackLength();
            
            // ---------------------------
            // PEEK --> on the empty stack
            // ---------------------------
            genericStack.Peek();

            // ---------------------------
            // PUSH
            // ---------------------------
            StringBuilder newItems = new StringBuilder();
            foreach (var item in itemsToPush)
            {
                genericStack.Push(item);
                newItems.Append($"{item} ");
            }
            Console.WriteLine($"PUSH: {newItems}\n");
            genericStack.StackLength();

            // ---------------------------
            // PEEK / POP
            // ---------------------------
            for (int i = 0; i < itemsToPush.Count; i++)
            {
                genericStack.Peek();
                genericStack.Pop();
                genericStack.StackLength();
            }

            // ---------------------------
            // POP  --> on the empty stack
            // ---------------------------
            genericStack.Pop();

            Console.ReadLine();
        }
        #endregion
    }
}
