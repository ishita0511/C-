using System;

class StackException : Exception
    {
        public StackException() : base() { }
        public StackException(string message) : base(message)
        {
        }
    }

    class Stack
    {
        int[] stack;
        int top, size;

        public Stack(int size)
        {
            this.size = size;
            this.stack = new int[size];
            this.top = -1;
        }

        public void Push(int value)
        {
            try{
            if (this.top == this.size - 1)
                throw new StackException();
            else
                this.stack[++this.top] = value;
            }
            catch(Exception ex )
            {
                Console.Write("Stack Overflow {0}",ex.Message);
             }
        }

        public void Pop()
        {
            try{
            if (this.top == -1)
                throw new StackException();
            else
            {
                Console.WriteLine("{0} popped", this.stack[top]);
                this.top--;
            }
        }
         catch(Exception ex )
         {
             Console.Write("stack underflow {0}",ex.Message); 
         }
        }

        public void DisplayStack()
        {
            Console.WriteLine("\nStack values: ");
            if (top > -1)
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write("{0} ", stack[i]);
                }
                Console.WriteLine("/n");
            }
            else
                Console.WriteLine("We have an Empty Stack..");
        }
    }
    
     class StackMain
     {
        static void Main()
        {
            Console.WriteLine("Enter the size of the stack");
            int size = Convert.ToInt32(Console.ReadLine());
            int choice = 0;

            Stack obj = new Stack(size);

            while (choice != 4)
            {
                Console.WriteLine("\n1. Push\n2. Pop\n3. Display Stack\n4. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a value you want to push ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        obj.Push(value);
                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.DisplayStack();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the process..");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }
        }
    }
