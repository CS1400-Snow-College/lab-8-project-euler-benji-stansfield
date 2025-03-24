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
string eulerProblem = userChoice switch
{
    1 => MultiplesOf3Or5(),
    2 => EvenFibonacciNumbers(),
    3 => SmallestMultiple(),
    4 => Prime10_001(),
};
