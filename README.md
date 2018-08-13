# Tower-Of-Hanoi
Tower Of Hanoi from Coding Challenges by Silvio Duka

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
