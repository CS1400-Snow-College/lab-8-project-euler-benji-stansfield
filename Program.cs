/*Benji Stansfield, 03-18-25, Lab 8 "Euler Project"*/
Console.Clear();

/*List the menu*/
Console.WriteLine(@"This is a program that will demonstrate the solution to a Euler Project problem.
1 - Multiples of 3 or 5
2 - Even Fibonacci Numbers
3 - Smallest Multiple
4 - 10,001st Prime
");
Console.Write("What is your selection? (1-4): ");
int userChoice = Convert.ToInt32(Console.ReadLine());

/*Creating the menu selections*/
int eulerProblem = userChoice switch
{
    1 => MultiplesOf3Or5(1000),
    /*2 => EvenFibonacciNumbers(),
    3 => SmallestMultiple(),
    4 => Prime10_001(),*/
};

static int MultiplesOf3Or5(int multiple)
{
    Console.WriteLine(@"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.");

    int sum = 0;

    for(int i = 1; i<1000; i++)
    {
        if(i % 3 == 0 || i % 5 == 0)
        {
            sum += i;
        }
    }

    Console.WriteLine($"Answer: {sum}");
    return sum;
}
