namespace Stack
{
    internal class MyStack<T>
    {
        internal T Value { get; }
        internal MyStack<T> Previous { get; set; }

        public MyStack(T value)
        {
            this.Value = value;
        }
    }
}
