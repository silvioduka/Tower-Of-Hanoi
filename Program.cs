/*
Tower Of Hanoi from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-02

The objective of the puzzle is to move the entire stack to another rod, obeying the following simple rules: 
- Only one disk can be moved at a time. 
- Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack. 
- No disk may be placed on top of a smaller disk. 

To create an solution algorithm, let's start with two disks: 
- First, we move the smaller (top) disk to the middle rod. 
- Then, we move the larger (bottom) disk to the destination rod. 
- And finally, we move the smaller disk from the middle to the destination rod. 

For a general algorithm we need to divide the stack into two parts - the largest disk (nth disk) is in one part and all other (n-1) disks are in the second part. 
Our ultimate goal is to move disk n from source to destination and then put all other (n-1) disks onto it. 
So, we can break up the problem into smaller problems and come up with a general algorithm: 
Step 1: Move n-1 disks from source to the middle. 
Step 2: Move nth disk from source to destination. 
Step 3: Move n-1 disks from the middle to destination. 

With 3 disks, the puzzle can be solved in 7 moves. 
The minimal number of moves required to solve a Tower of Hanoi puzzle is 2^n-1, where n is the number of disks. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static Stack<string> stackA;
        static Stack<string> stackB;
        static Stack<string> stackC;
        static int i = 1;
        static int disks = 4; // Insert number of Disks

        static void Main(string[] args)
        {
            stackA = new Stack<string>();
            stackB = new Stack<string>();
            stackC = new Stack<string>();

            for (int n = disks; n > 0; n--)
                stackA.Push(n.ToString());

            printStacks();

            Move(disks, "A", "B", "C");
        }

        static void Move(int n, string a, string b, string c)
        {
            if (n == 1)
            {
                Console.WriteLine($"Step {i++}: Move disk from {a} to {c}\n");

                string s = (a == "A") ? stackA.Pop() : ((a == "B") ? stackB.Pop() : stackC.Pop());

                switch (c)
                {
                    case "A":
                        stackA.Push(s);
                        break;
                    case "B":
                        stackB.Push(s);
                        break;
                    case "C":
                        stackC.Push(s);
                        break;
                }

                printStacks();

                return;
            }

            Move(n - 1, a, c, b);
            Move(1, a, b, c);
            Move(n - 1, b, a, c);
        }

        static void printStacks()
        {
            string[] sA = stackA.ToArray();
            string[] sB = stackB.ToArray();
            string[] sC = stackC.ToArray();

            if (i == 1) Console.WriteLine("BEGIN:\n");

            for (int i = disks; i >= 0; i--)
            {
                Console.Write("        ");
                Console.Write($"  {((i < sA.Length) ? sA[sA.Length - i - 1] : "|")}");
                Console.Write($"  {((i < sB.Length) ? sB[sB.Length - i - 1] : "|")}");
                Console.Write($"  {((i < sC.Length) ? sC[sC.Length - i - 1] : "|")}");
                Console.WriteLine();
            }

            Console.WriteLine("        -----------");
            Console.WriteLine("          A  B  C  ");
            Console.WriteLine("_____________________________\n");
        }
    }
}