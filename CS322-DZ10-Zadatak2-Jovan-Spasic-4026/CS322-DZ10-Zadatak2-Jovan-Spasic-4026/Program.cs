namespace CS322_DZ10_Zadatak2_Jovan_Spasic_4026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack example");
            MyStack stack = new MyStack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.print();
            stack.pop();
            stack.print();
            Console.WriteLine();

            Console.WriteLine("Queue example");
            MyQueue queue = new MyQueue();
            queue.push(1);
            queue.push(2);
            queue.push(3);
            queue.print();
            queue.pop();
            queue.print();
        }
    }
}